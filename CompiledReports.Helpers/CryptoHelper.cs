using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CompiledReports.Helpers
{
    public static class CryptoHelper
    {
        public static string GetMd5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
 
            return sBuilder.ToString();
        }

        //public static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        //{
        //    string hashOfInput = GetMd5Hash(md5Hash, input);

        //    StringComparer comparer = StringComparer.OrdinalIgnoreCase;

        //    if (comparer.Compare(hashOfInput, hash) == 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
