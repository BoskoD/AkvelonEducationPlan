using System;
using System.Security.Cryptography;
using System.Text;

namespace HashFunction_SHA256
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "Bosko";
            Console.WriteLine($"Raw data: {data}");

            string hashedData = ComputeSha256Hash(data);
            Console.WriteLine($"Hashed data: {hashedData}");

            Console.ReadLine();
        }

        private static string ComputeSha256Hash(string data)
        {
            using SHA256 sHA256 = SHA256.Create();
            // compute hash => returns byte array
            byte[] bytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(data));

            StringBuilder sb = new StringBuilder();
            // convert byte array into a string
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
