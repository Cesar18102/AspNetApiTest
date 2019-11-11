using System;

using Newtonsoft.Json;

namespace TestAppClient.Model
{
    [JsonObject]
    public class Payment : ModelElement
    {
        [JsonRequired]
        public UserInfo creator { get; private set; }

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

        public Payment(string firstName, string lastName, string patronymic,
                       double amount, DateTime payDate, bool payed)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.patronymic = patronymic;
            this.amount = amount;
            this.payDate = payDate;
            this.payed = payed;
        }
    }
}
