using System;
using System.Collections.Generic;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;
using SecretUtils.Crypto;

namespace SMDemo
{
    public class Sm4Utils
    {
        public static string EncryptEBC(string plaintext, string key)
        {
            var dataBytes = Encoding.UTF8.GetBytes(plaintext);
            var keyBytes = Encoding.UTF8.GetBytes(key);

            KeyParameter keyParam = ParameterUtilities.CreateKeyParameter("SM4", keyBytes);
            IBufferedCipher inCipher = CipherUtilities.GetCipher("SM4/ECB/PKCS7Padding");
            inCipher.Init(true, keyParam);
            byte[] cipher = inCipher.DoFinal(dataBytes);
            return Hex.ToHexString(cipher, 0, cipher.Length);
        }

        public static string DecryptEBC(string chipherText, string key)
        {
            var dataBytes = Hex.Decode(chipherText);
            var keyBytes = Encoding.UTF8.GetBytes(key);

            KeyParameter keyParam = ParameterUtilities.CreateKeyParameter("SM4", keyBytes);
            IBufferedCipher inCipher = CipherUtilities.GetCipher("SM4/ECB/PKCS7Padding");
            inCipher.Init(false, keyParam);
            byte[] plain = inCipher.DoFinal(dataBytes);
            return Encoding.UTF8.GetString(plain);
        }


        /// <summary>
        /// CBC模式加密
        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string EncryptCBC(string plaintext, string key)
        {
            var dataBytes = Encoding.UTF8.GetBytes(plaintext);
            var keyBytes = Encoding.UTF8.GetBytes(key);

            KeyParameter keyParam = ParameterUtilities.CreateKeyParameter("SM4", keyBytes);
            ParametersWithIV keyParamWithIv = new ParametersWithIV(keyParam, keyBytes);

            IBufferedCipher inCipher = CipherUtilities.GetCipher("SM4/CBC/PKCS7Padding");
            inCipher.Init(true, keyParamWithIv);
            byte[] cipher = inCipher.DoFinal(dataBytes);
            return Hex.ToHexString(cipher, 0, cipher.Length);

        }

        /// <summary>
        /// CBC模式解密
        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string DecryptCBC(string chipherText, string key)
        {
            var dataBytes = Hex.Decode(chipherText);
            var keyBytes = Encoding.UTF8.GetBytes(key);

            KeyParameter keyParam = ParameterUtilities.CreateKeyParameter("SM4", keyBytes);
            ParametersWithIV keyParamWithIv = new ParametersWithIV(keyParam, keyBytes);

            IBufferedCipher inCipher = CipherUtilities.GetCipher("SM4/CBC/PKCS7Padding");
            inCipher.Init(false, keyParamWithIv);
            byte[] plain = inCipher.DoFinal(dataBytes);
            return Encoding.UTF8.GetString(plain);

        }


    }
}
