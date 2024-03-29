﻿using System;
using System.Windows.Forms;

using Autofac;

using TestAppClient.Model;
using TestAppClient.Controllers;
using TestAppClient.ServerAccess.Impl;
using TestAppClient.Util.Validation.Templates;

namespace TestAppClient.Forms
{
    public partial class PaymentAddForm : Form
    {
        private static PaymentFormValidator<Control> FormValidator { get; set; }

        public PaymentAddForm()
        {
            InitializeComponent();
            FormValidator = new PaymentFormValidator<Control>(FirstNameInput, LastNameInput, PatronymicInput);
        }

        private async void ConfirmPaymentButton_Click(object sender, EventArgs e)
        {
            if(!FormValidator.ValidateAll())
            {
                MessageBox.Show("Invalid data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                UseWaitCursor = true;

                Payment payment = await Program.DI.Resolve<PaymentController>().Add(
                    new AddPaymentForm(
                        Program.DI.Resolve<Session>(),
                        FirstNameInput.Text, 
                        LastNameInput.Text,
                        PatronymicInput.Text == "" ? null : PatronymicInput.Text,
                        (double)AmountInput.Value, 
                        DateInput.Value.Add(TimeInput.Value.TimeOfDay),
                        PayedInput.Checked)
                    );

                UseWaitCursor = false;

                if (MessageBox.Show("Желаете добавить еще одну запись?", "Запись добавлена!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    this.Close();

                Reset();
            }
            catch(ResponseException ex)
            {
                UseWaitCursor = false;
                MessageBox.Show(ex.message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset()
        {
            FirstNameInput.ResetText();
            LastNameInput.ResetText();
            PatronymicInput.ResetText();
            AmountInput.Value = AmountInput.Minimum;
            DateInput.Value = DateTime.Now;
            TimeInput.Value = DateTime.Now;
            PayedInput.Checked = false;
        }
    }
}
