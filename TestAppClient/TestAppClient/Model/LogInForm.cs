using System;

using Newtonsoft.Json;

using TestAppClient.Util.Encryption;

namespace TestAppClient.Model
{
    [JsonObject]
    public class LogInForm
    {
        private static readonly Random R = new Random();

        private const int MIN_RAND = 1000;
        private const int MAX_RAND = 10000;

        public string login { get; private set; }
        public string passwordEncoded { get; private set; }
        public string seed { get; private set; }

        public LogInForm(string login, string password)
        {
            this.login = login;
            this.seed = R.Next(MIN_RAND, MAX_RAND).ToString();
            this.passwordEncoded = Encryptor.Encrypt(Encryptor.Encrypt(password) + seed);
        }
    }
}
