using System;
using System.ComponentModel.DataAnnotations;

using Newtonsoft.Json;

using AspNetBlankAppTest.Models;

namespace AspNetBlankAppTest.Dto
{
    [JsonObject]
    public class PaymentFormDto : IForm
    {
        [Required]
        public UserSession session { get; private set; }

        [Required]
        public string firstName { get; private set; }

        [Required]
        public string lastName { get; private set; }

        public string patronymic { get; private set; }

        [Required]
        public double amount { get; private set; }

        [Required]
        public DateTime payDate { get; private set; }

        [Required]
        public bool payed { get; private set; }

        public PaymentFormDto(UserSession session, string firstName, string lastName, string patronymic, double amount, DateTime payDate, bool payed)
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