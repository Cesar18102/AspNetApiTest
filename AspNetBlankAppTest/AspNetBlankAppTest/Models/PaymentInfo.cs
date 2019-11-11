using System;

using Newtonsoft.Json;

using AspNetBlankAppTest.Dto;

namespace AspNetBlankAppTest.Models
{
    [JsonObject]
    public class PaymentInfo
    {
        public UserInfo creator { get; private set; }
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public string patronymic { get; private set; }
        public double amount { get; private set; }
        public DateTime payDate { get; private set; }
        public bool payed { get; private set; }

        public PaymentInfo(int user_id, string login, string firstName, string lastName, string patronymic, double amount, DateTime payDate, bool payed)
        {
            this.creator = new UserInfo(user_id, login);
            this.firstName = firstName;
            this.lastName = lastName;
            this.patronymic = patronymic;
            this.amount = amount;
            this.payDate = payDate;
            this.payed = payed;
        }

        public static implicit operator PaymentInfo(PaymentFormDto payForm) => 
            new PaymentInfo(payForm.session.id, payForm.session.login, 
                            payForm.firstName, payForm.lastName, payForm.patronymic, 
                            payForm.amount, payForm.payDate, payForm.payed
            );
    }
}