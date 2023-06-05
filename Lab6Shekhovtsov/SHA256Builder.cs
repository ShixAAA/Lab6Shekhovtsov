using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Lab6Shekhovtsov
{
    internal class SHA256Builder
    {
        public static string ConvertToHash(string text) 
        {
            SHA256 sHA256 = SHA256.Create();
            byte[] bytes = Encoding.ASCII.GetBytes(text);
            byte[] hash = sHA256.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash) 
                sb.Append(b.ToString("X2"));
            return sb.ToString();
        }
    }
}
