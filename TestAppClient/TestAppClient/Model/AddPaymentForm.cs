using System;

namespace TestAppClient.Model
{
    public class AddPaymentForm
    {
        public Session session { get; private set; }
        public int user_id { get; private set; }
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public string patronymic { get; private set; }
        public double amount { get; private set; }
        public DateTime payDate { get; private set; }
        public bool payed { get; private set; }

        public AddPaymentForm(Session session, int user_id, 
                              string firstName, string lastName, string patronymic, 
                              double amount, DateTime payDate, bool payed)
        {
            this.session = session;
            this.user_id = user_id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.patronymic = patronymic;
            this.amount = amount;
            this.payDate = payDate;
            this.payed = payed;
        }
    }
}
