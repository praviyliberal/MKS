using System;
using System.Security.Cryptography;
using System.Text;

namespace WpfApp3
{
    class md5
    {
            public static string hashPassword(string password)
            {
                MD5 md5 = MD5.Create();
                byte[] b = Encoding.ASCII.GetBytes(password);
                byte[] result = md5.ComputeHash(b);

                StringBuilder sb = new StringBuilder();
                foreach (var a in result) sb.Append(a.ToString());

                return Convert.ToString(sb);
            }
    }
}
