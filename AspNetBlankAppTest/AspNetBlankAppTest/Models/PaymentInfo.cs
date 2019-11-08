using System;

using Newtonsoft.Json;

namespace AspNetBlankAppTest.Models
{
    [JsonObject]
    public class PaymentInfo
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Patronymic { get; private set; }
        public double Amount { get; private set; }
        public DateTime Date { get; private set; }
        public bool Payed { get; private set; }
    }
}