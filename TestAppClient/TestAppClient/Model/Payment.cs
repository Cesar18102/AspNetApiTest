using System;

using Newtonsoft.Json;

namespace TestAppClient.Model
{
    [JsonObject]
    public class Payment : ModelElement
    {
        [JsonRequired]
        public int user_id { get; private set; }

        [JsonRequired]
        public string firstName { get; private set; }

        [JsonRequired]
        public string lastName { get; private set; }

        [JsonProperty(Required = Required.AllowNull)]
        public string patronymic { get; private set; }

        [JsonRequired]
        public double amount { get; private set; }

        [JsonRequired]
        public DateTime payDate { get; private set; }

        [JsonRequired]
        public bool payed { get; private set; }

        public Payment() { }
    }
}
