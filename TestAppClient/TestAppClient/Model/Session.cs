using Newtonsoft.Json;

namespace TestAppClient.Model
{
    [JsonObject]
    public class Session : ModelElement
    {
        [JsonRequired]
        public int id { get; private set; }

        [JsonRequired]
        public string login { get; private set; }

        [JsonRequired]
        public string hash { get; private set; }

        public Session() { }

        public void Update(Session session)
        {
            id = session.id;
            login = session.login;
            hash = session.hash;
        }
    }
}
