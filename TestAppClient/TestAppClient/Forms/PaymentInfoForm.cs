using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

using Autofac;

using TestAppClient.Model;
using TestAppClient.Controllers;
using System.Linq;

namespace TestAppClient.Forms
{
    public partial class PaymentInfoForm : Form
    {
        private IEnumerable<Payment> Payments = new List<Payment>();
        private List<Predicate<Payment>> Filters = new List<Predicate<Payment>>();
        private Session session = Program.DI.Resolve<Session>();

        public PaymentInfoForm()
        {
            InitializeComponent();
        }

        private async void PaymentInfoForm_Load(object sender, EventArgs e) => await LoadPaymentsAndFillTable();
        private async void MyPaymentsOnlyFilter_CheckedChanged(object sender, EventArgs e) => await LoadPaymentsAndFillTable();

        private async void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PaymentAddForm().ShowDialog();
            await LoadPaymentsAndFillTable();
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            UpdateFilters();
            FillTable();
        }

        private async Task LoadPaymentsAndFillTable()
        {
            await LoadPayments();
            FillTable();
        }

        private async Task LoadPayments()
        {
            UseWaitCursor = true;

            PaymentController paymentController = Program.DI.Resolve<PaymentController>();
            Payments = await (MyPaymentsOnlyFilter.Checked ? paymentController.GetByCreator(session.id) : 
                                                             paymentController.GetAll());

            UseWaitCursor = false;
        }

        private void FillTable() =>
            PaymentsDataGridView.DataSource = Payments.Where(P => !Filters.Exists(F => !F(P))).ToList();

        private void UpdateFilters()
        {
            Filters.Clear();

            if (!PayedAndUnpayed.Checked)
                Filters.Add(P => P.payed == Payed.Checked);
        }
    }
}
