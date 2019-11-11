using Newtonsoft.Json;

namespace TestAppClient.Model
{
    [JsonObject]
    public class SignUpForm
    {
        public string login { get; private set; }
        public string password { get; private set; }

        public SignUpForm(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
    }
}
