using System;

using Newtonsoft.Json;

namespace TestAppClient.Model
{
    [JsonObject]
    public class AddPaymentForm
    {
        public Session session { get; private set; }
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public string patronymic { get; private set; }
        public double amount { get; private set; }
        public DateTime payDate { get; private set; }
        public bool payed { get; private set; }

        public AddPaymentForm(Session session, string firstName, string lastName, string patronymic, 
                              double amount, DateTime payDate, bool payed)
        {
            this.session = session;
            this.firstName = firstName;
            this.lastName = lastName;
            this.patronymic = patronymic;
            this.amount = amount;
            this.payDate = payDate;
            this.payed = payed;
        }
    }
}
