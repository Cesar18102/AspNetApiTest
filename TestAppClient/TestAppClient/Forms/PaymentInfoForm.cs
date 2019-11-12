using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

using Autofac;

using TestAppClient.Model;
using TestAppClient.Controllers;
using TestAppClient.Util.Export;

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

        private List<Payment> GetFilteredPayments() => Payments.Where(P => !Filters.Exists(F => !F(P))).ToList();

        private void FillTable() => PaymentsDataGridView.DataSource = GetFilteredPayments();

        private void UpdateFilters()
        {
            Filters.Clear();

            if (!PayedAndUnpayed.Checked)
                Filters.Add(P => P.payed == Payed.Checked);

            Filters.Add(P => $"{P.firstName} {P.lastName} {P.patronymic}".ToLower().Contains(PayerSearchInput.Text.ToLower()) ||
                             $"{P.firstName} {P.patronymic} {P.lastName}".ToLower().Contains(PayerSearchInput.Text.ToLower()) ||
                             $"{P.lastName} {P.firstName} {P.patronymic}".ToLower().Contains(PayerSearchInput.Text.ToLower()) ||
                             $"{P.lastName} {P.patronymic} {P.firstName}".ToLower().Contains(PayerSearchInput.Text.ToLower()) ||
                             $"{P.patronymic} {P.firstName} {P.lastName}".ToLower().Contains(PayerSearchInput.Text.ToLower()) ||
                             $"{P.patronymic} {P.lastName} {P.firstName}".ToLower().Contains(PayerSearchInput.Text.ToLower()));

        }

        private async void ExcelExportButton_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;

            FileDialog fileDialog = new SaveFileDialog() { InitialDirectory = Environment.CurrentDirectory, DefaultExt = ".xlsx" };

            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            await Task.Run(() =>
            {
                List<Payment> payments = GetFilteredPayments();
                new ExcelExportContext().Export<Payment>(fileDialog.FileName, payments, "payments");
            });

            UseWaitCursor = false;

            MessageBox.Show("Данные успешно экспортированы!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void LogOutButton_Click(object sender, EventArgs e)
        {
            await Program.DI.Resolve<AuthController>().LogOut(session);
            this.Close();
        }
    }
}
