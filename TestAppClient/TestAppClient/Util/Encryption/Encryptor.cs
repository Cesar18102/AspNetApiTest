using System;
using System.Text;
using System.Security.Cryptography;

namespace TestAppClient.Util.Encryption
{
    public static class Encryptor
    {
        private static readonly MD5 mD5 = MD5.Create();

        public static string Encrypt(string str) => BitConverter.ToString(mD5.ComputeHash(Encoding.UTF8.GetBytes(str))).Replace("-", "");
    }
}
