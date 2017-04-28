using CryptAES256.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptAES256
{
    /// <summary>
    /// Implement based on https://securityblog.gr/3340/aes-256-and-base64-using-cryptoapi-and-c-2/
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            var TEXT = new
            {
                Username = "jose.silva@testserver.com.br",
                Password = "123456Test&"
            };//"Valor a ser Decriptado";

            Guid d = Guid.NewGuid();

            string SHARED_KEY =  d.ToString(); 

            String encryptedText = CryptUtils.Encrypt(TEXT.ToString(), SHARED_KEY);

            Console.WriteLine(encryptedText);

            Console.WriteLine("\n\n\n");

            String decryptedText = CryptUtils.Decrypt(encryptedText, SHARED_KEY);
            
            Console.WriteLine(decryptedText);            

        }
    }
}
