using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMDemo
{
    public class SM2KeyPair
    {
        public string PrivateKey { get; set; } //私钥
        public string PublicKey { get; set; } //公钥

    }
    public class SM2Utils
    {
        //国密标准256位曲线参数
        BigInteger SM2_ECC_P = new BigInteger("FFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF00000000FFFFFFFFFFFFFFFF", 16);
        BigInteger SM2_ECC_A = new BigInteger("FFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF00000000FFFFFFFFFFFFFFFC", 16);
        BigInteger SM2_ECC_B = new BigInteger("28E9FA9E9D9F5E344D5A9E4BCF6509A7F39789F515AB8F92DDBCBD414D940E93", 16);
        BigInteger SM2_ECC_N = new BigInteger("FFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFF7203DF6B21C6052B53BBF40939D54123", 16);
        BigInteger SM2_ECC_H = BigInteger.One;
        BigInteger SM2_ECC_GX = new BigInteger("32C4AE2C1F1981195F9904466A39C9948FE30BBFF2660BE1715A4589334C74C7", 16);
        BigInteger SM2_ECC_GY = new BigInteger("BC3736A2F4F6779C59BDCEE36B692153D0A9877CC62A474002DF32E52139F0A0", 16);

        public SM2KeyPair GenerateKey()
        {
            ECCurve curve = new FpCurve(SM2_ECC_P, SM2_ECC_A, SM2_ECC_B, SM2_ECC_N, SM2_ECC_H);
            ECPoint g = curve.CreatePoint(SM2_ECC_GX, SM2_ECC_GY);
            ECDomainParameters domainParams = new ECDomainParameters(curve, g, SM2_ECC_N);
            ECKeyPairGenerator keyPairGenerator = new ECKeyPairGenerator();
            ECKeyGenerationParameters aKeyGenParams = new ECKeyGenerationParameters(domainParams, new SecureRandom());
            keyPairGenerator.Init(aKeyGenParams);
            AsymmetricCipherKeyPair aKp = keyPairGenerator.GenerateKeyPair();
            ECPublicKeyParameters aPub = (ECPublicKeyParameters)aKp.Public;
            ECPrivateKeyParameters aPriv = (ECPrivateKeyParameters)aKp.Private;

            BigInteger privateKey = aPriv.D;
            ECPoint publicKey = aPub.Q;

            byte[] pubkey = Hex.Encode(publicKey.GetEncoded());
            string temp_pubkey = Encoding.UTF8.GetString(pubkey);

            string temp_prikey = Encoding.UTF8.GetString(Hex.Encode(privateKey.ToByteArray()));

            return new SM2KeyPair() { PrivateKey = temp_prikey, PublicKey = temp_pubkey };
        }

        /// <summary>
        /// 加密函数
        /// </summary>
        /// <param name="publicKeyStr"></param>
        /// <param name="plainText"></param>
        /// <returns></returns>
        public string Encrypt(string publicKeyStr, string plainText)
        {
            byte[] publicKey = Hex.Decode(publicKeyStr);
            byte[] data = Encoding.UTF8.GetBytes(plainText);

            if (null == publicKey || publicKey.Length == 0)
            {
                return null;
            }
            if (data == null || data.Length == 0)
            {
                return null;
            }
            byte[] source = new byte[data.Length];
            Array.Copy(data, 0, source, 0, data.Length);
            ECCurve curve = new FpCurve(SM2_ECC_P, SM2_ECC_A, SM2_ECC_B, SM2_ECC_N, SM2_ECC_H);
            ECPoint g = curve.CreatePoint(SM2_ECC_GX, SM2_ECC_GY);
            ECDomainParameters domainParams = new ECDomainParameters(curve, g, SM2_ECC_N);
            ECPoint userkey = curve.DecodePoint(publicKey);
            ECPublicKeyParameters aPub = new ECPublicKeyParameters(userkey, domainParams);

            SM2Engine sm2Engine = new SM2Engine();
            sm2Engine.Init(true, new ParametersWithRandom(aPub));
            byte[] enc = sm2Engine.ProcessBlock(source, 0, source.Length);
            return Encoding.UTF8.GetString(Hex.Encode(enc));

        }


        /// <summary>
        /// 解密函数
        /// </summary>
        /// <param name="privateKey"></param>
        /// <param name="encryptedData"></param>
        /// <returns></returns>
        public string Decrypt(string privateKeyStr, string chiperText)
        {
            byte[] privateKey = Hex.Decode(privateKeyStr);
            byte[] encryptedData = Hex.Decode(chiperText);

            if (null == privateKey || privateKey.Length == 0)
            {
                return null;
            }
            if (encryptedData == null || encryptedData.Length == 0)
            {
                return null;
            }

            byte[] enc = new byte[encryptedData.Length];
            Array.Copy(encryptedData, 0, enc, 0, encryptedData.Length);
            BigInteger userD = new BigInteger(1, privateKey);
            ECCurve curve = new FpCurve(SM2_ECC_P, SM2_ECC_A, SM2_ECC_B, SM2_ECC_N, SM2_ECC_H);
            ECPoint g = curve.CreatePoint(SM2_ECC_GX, SM2_ECC_GY);
            ECDomainParameters domainParams = new ECDomainParameters(curve, g, SM2_ECC_N);
            ECPrivateKeyParameters aPriv = new ECPrivateKeyParameters(userD, domainParams);

            SM2Engine sm2Engine = new SM2Engine();
            sm2Engine.Init(false, aPriv);
            byte[] dec = sm2Engine.ProcessBlock(enc, 0, enc.Length);
            return Encoding.UTF8.GetString(dec);
        }
    }
}
