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
        private static readonly string key = "0123456789abcdef";
        private static readonly string iv = "abcdef0123456789";


        public static byte[] EncryptAES(string plaintext)
        {
            using (AesCryptoServiceProvider aesAlg = new AesCryptoServiceProvider())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = Encoding.UTF8.GetBytes(iv);
                aesAlg.Padding = PaddingMode.PKCS7;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                byte[] encryptedBytes;
                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plaintext);
                        }
                    }
                    encryptedBytes = msEncrypt.ToArray();
                }

                return encryptedBytes;
            }
        }

        public static string DecryptAES(byte[] ciphertext)
        {
            using (AesCryptoServiceProvider aesAlg = new AesCryptoServiceProvider())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = Encoding.UTF8.GetBytes(iv);
                aesAlg.Padding = PaddingMode.PKCS7;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                string decryptedText;
                using (var msDecrypt = new System.IO.MemoryStream(ciphertext))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                        {
                            decryptedText = srDecrypt.ReadToEnd();
                        }
                    }
                }

                return decryptedText;
            }
        }

        /// <summary>
        /// Funcion para decodificar el Base64
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static string Base64Decode(string texto)
        {
            string base64Decoded;
            byte[] data = Convert.FromBase64String(texto);
            base64Decoded = Encoding.ASCII.GetString(data);
            return base64Decoded;
        }
    }
}
