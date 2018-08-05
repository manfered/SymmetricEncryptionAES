using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricEncryptionAES
{
    class Program
    {
        static void Main(string[] args)
        {
            var aes = new AESEncryption();
            var key = aes.GenerateRandomNumber(32);
            var iv = aes.GenerateRandomNumber(16);

            const string message = "Message to Encrypt";

            var encrypted = aes.Encrypt(Encoding.UTF8.GetBytes(message), key, iv);
            var decrypted = aes.Decrypt(encrypted, key, iv);

            var decryptedMessage = Encoding.UTF8.GetString(decrypted);

            Console.WriteLine("AES Encryption");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine($"Message text : {message}");
            Console.WriteLine($"Encryption Text = {Convert.ToBase64String(encrypted)}");
            Console.WriteLine($"Decrypted Text = {decryptedMessage}");

        }
    }
}
