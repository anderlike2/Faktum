using System.Security.Cryptography;
using System.Text;

namespace Commun
{
    /// <summary>
    /// Anderson Benavides
    /// Clase para el manejo de encriptaciones
    /// </summary>
    //[Authorize]
    public static class ManejoEncriptacion
    {
        private static readonly string key = "FAkT_um*";

        /// <summary>
		/// Desencriptar cadenas de conexión Sodimac
		/// </summary>
		/// <param name="connectionString"></param>
		/// <returns></returns>
		public static string DeCrypt(this string parametros)
        {
            string data = Base64Decode(parametros);
            data = data.Replace("\"\\n  ", "");
            data = data.Replace(@"\\n\\n\\n  \", "");
            data = data.Replace(@"\\n\\n\\n  \", "");
            data = data.Replace("\\n  ", "");
            data = data.Replace("\\", "");
            data = data.Replace("nn", "");
            data = data.Replace("}  ]}'", @" }]}");
            return data;
        }

        public static string Base64Decode(string plainText)
        {
            string base64Decoded;
            byte[] data = Convert.FromBase64String(plainText);
            base64Decoded = Encoding.ASCII.GetString(data);
            return OpenSSLDecrypt(base64Decoded);
        }

        public static string OpenSSLDecrypt(string encrypted)
        {
            byte[] numArray = Convert.FromBase64String(encrypted);
            byte[] salt = new byte[8];
            byte[] cipherText = new byte[numArray.Length - salt.Length - 8];
            Buffer.BlockCopy(numArray, 8, salt, 0, salt.Length);
            Buffer.BlockCopy(numArray, salt.Length + 8, cipherText, 0, cipherText.Length);
            DeriveKeyAndIV(salt, out var keyByte, out var iv);
            return DecryptStringFromBytesAes(cipherText, keyByte, iv);
        }

        private static void DeriveKeyAndIV(byte[] salt, out byte[] key, out byte[] iv)
        {
            List<byte> byteList = new List<byte>(48);
            byte[] bytes = Encoding.UTF8.GetBytes(ManejoEncriptacion.key);
            byte[] numArray = Array.Empty<byte>();
            bool flag = false;
            while (!flag)
            {
                byte[] buffer = new byte[numArray.Length + bytes.Length + salt.Length];
                Buffer.BlockCopy(numArray, 0, buffer, 0, numArray.Length);
                Buffer.BlockCopy(bytes, 0, buffer, numArray.Length, bytes.Length);
                Buffer.BlockCopy(salt, 0, buffer, numArray.Length + bytes.Length, salt.Length);
                using (SHA512 sha512 = SHA512.Create())
                {
                    numArray = sha512.ComputeHash(buffer);
                }
                byteList.AddRange(numArray);
                if (byteList.Count >= 48)
                    flag = true;
            }
            key = new byte[32];
            iv = new byte[16];
            byteList.CopyTo(0, key, 0, 32);
            byteList.CopyTo(32, iv, 0, 16);
        }

        private static string DecryptStringFromBytesAes(byte[] cipherText, byte[] key, byte[] iv)
        {
            if (cipherText == null || cipherText.Length == 0)
                throw new ArgumentNullException(nameof(cipherText));
            if (key == null || key.Length == 0)
                throw new ArgumentNullException(nameof(key));
            if (iv == null || iv.Length == 0)
                throw new ArgumentNullException(nameof(iv));
            var aes1 = Aes.Create("AesManaged");
            string end = string.Empty;
            try
            {
                var aes2 = Aes.Create("AesManaged");
                if (aes2 != null)
                {
                    aes2.Mode = CipherMode.CBC;
                    aes2.KeySize = 256;
                    aes2.BlockSize = 128;
                    aes2.Key = key;
                    aes2.IV = iv;
                    aes1 = aes2;
                    ICryptoTransform decryptor = aes1.CreateDecryptor(aes1.Key, aes1.IV);
                    using MemoryStream memoryStream = new MemoryStream(cipherText);
                    using CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                    using StreamReader streamReader = new StreamReader(cryptoStream);
                    end = streamReader.ReadToEnd();
                    streamReader.Close();
                    cryptoStream.Close();
                    memoryStream.Close();
                }
            }
            finally
            {
                aes1?.Clear();
            }
            return end;
        }
    }
}
