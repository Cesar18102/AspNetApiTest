using Newtonsoft.Json;

namespace AspNetBlankAppTest.Models
{
    [JsonObject]
    public class UserSession
    {
        public int id { get; private set; }
        public string login { get; private set; }
        public string hash { get; private set; }

        public UserSession(int id, string login, string hash)
        {
            this.id = id;
            this.login = login;
            this.hash = hash;
        }
    }
}