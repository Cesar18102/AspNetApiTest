using System;
using System.Text;
using System.Security.Cryptography;

namespace AspNetBlankAppTest.Util.Encryption
{
    public class PasswordEncrypter
    {
        private static readonly MD5 mD5 = MD5.Create();

        public static string Encrypt(string password) => BitConverter.ToString(mD5.ComputeHash(Encoding.UTF8.GetBytes(password))).Replace("-", "");
    }
}