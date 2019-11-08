using System.Runtime.Serialization;

using Newtonsoft.Json;

namespace AspNetBlankAppTest.Models
{
    [JsonObject]
    public class UserCredintails
    {
        [JsonRequired]
        public string login { get; private set; }

        [JsonIgnore]
        [JsonRequired]
        public string passwordEncoded { get; private set; }

        public UserCredintails(string login, string pwdEncoded)
        {
            this.login = login;
            this.passwordEncoded = pwdEncoded;
        }
    }
}