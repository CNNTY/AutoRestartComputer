using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WinRemoteDesktop
{
    public class xEncrypt
    {
        private const string ENCRYPT_KEY = "remote_desktop";

        public static string EncryptText(string strText)
        {
            return xEncrypt.Encrypt(strText, "remote_desktop");
        }

        public static string EncryptText(string strText, string strKey)
        {
            return xEncrypt.Encrypt(strText, strKey);
        }

        public static string DecryptText(string strText)
        {
            return xEncrypt.Decrypt(strText, "remote_desktop");
        }

        public static string DecryptText(string strText, string strKey)
        {
            return xEncrypt.Decrypt(strText, strKey);
        }

        private static string Encrypt(string strText, string strEncrKey)
        {
            byte[] rgbKey = new byte[0];
            byte[] rgbIV = new byte[]
			{
				18,
                52,
                86,
                120,
                144,
                171,
                205,
                239
			};
            rgbKey = Encoding.UTF8.GetBytes(strEncrKey.Substring(0, 8));
            
            DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
            
            byte[] bytes = Encoding.UTF8.GetBytes(strText);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
            cryptoStream.Write(bytes, 0, bytes.Length);
            cryptoStream.FlushFinalBlock();
            return Convert.ToBase64String(memoryStream.ToArray());
        }

        private static string Decrypt(string strText, string sDecrKey)
        {
            byte[] rgbKey = new byte[0];
            byte[] rgbIV = new byte[]
			{
				18,
                52,
                86,
                120,
                144,
                171,
                205,
                239
			};
            byte[] array = new byte[strText.Length];
            rgbKey = Encoding.UTF8.GetBytes(sDecrKey.Substring(0, 8));
            DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
            array = Convert.FromBase64String(strText);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
            cryptoStream.Write(array, 0, array.Length);
            if (strText != "")
            {
                cryptoStream.FlushFinalBlock();
            }
            Encoding uTF = Encoding.UTF8;
            return uTF.GetString(memoryStream.ToArray());
        }
    }
}
