using Newtonsoft.Json;

namespace TestAppClient.Model
{
    [JsonObject]
    public class UserInfo : ModelElement
    {
        [JsonRequired]
        public int id { get; private set; }

        [JsonRequired]
        public string login { get; private set; }

        public UserInfo() { }

        public override string ToString() => login;
    }
}
