using Newtonsoft.Json;

namespace AspNetBlankAppTest.Models
{
    [JsonObject]
    public class UserInfo
    {
        public int id { get; private set; }
        public string login { get; private set; }

        public UserInfo(int id, string login)
        {
            this.id = id;
            this.login = login;
        }
    }
}