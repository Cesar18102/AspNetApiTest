using System;
using System.Windows.Forms;
using System.Collections.Generic;

using Autofac;

using TestAppClient.Model;
using TestAppClient.Controllers;


namespace TestAppClient.Forms
{
    public partial class PaymentInfoForm : Form
    {
        public PaymentInfoForm()
        {
            InitializeComponent();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e) => new PaymentAddForm().ShowDialog();

        private async void PaymentInfoForm_Load(object sender, EventArgs e)
        {
            IEnumerable<Payment> payments = await Program.DI.Resolve<PaymentController>().GetAll();
            PaymentsDataGridView.DataSource = payments;
        }
    }
}
