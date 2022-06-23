using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMDemo
{
    public class Sm3Utils
    {
        public static string GetHash(string plainText)
        {
            String resultHexString = "";

            // 将字符串转换成byte数组
            byte[] srcData = Encoding.UTF8.GetBytes(plainText);
            SM3Digest digest = new SM3Digest();
            digest.BlockUpdate(srcData, 0, srcData.Length);
            byte[] hash = new byte[digest.GetDigestSize()];
            digest.DoFinal(hash, 0);
            // 将返回的hash值转换成16进制字符串
            resultHexString = new UTF8Encoding().GetString(Hex.Encode(hash));

            return resultHexString;
        }
    }
}
