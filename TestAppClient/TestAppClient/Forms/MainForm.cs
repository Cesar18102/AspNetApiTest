using System;
using System.Windows.Forms;
using System.Threading.Tasks;

using Autofac;

using TestAppClient.Model;
using TestAppClient.Controllers;
using TestAppClient.ServerAccess.Impl;

namespace TestAppClient.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void SignUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                UseWaitCursor = true;

                SignUpForm signUpForm = new SignUpForm(LoginInput.Text, PasswordInput.Text);
                Program.DI.Resolve<Session>().Update(await Program.DI.Resolve<SignUpController>().SignUp(signUpForm));

                UseWaitCursor = false;
                MessageBox.Show("Registration successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EnterSystem();
            }
            catch (ResponseException ex)
            {
                UseWaitCursor = false;
                MessageBox.Show(ex.message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LogInButton_Click(object sender, EventArgs e)
        {
            try
            {
                UseWaitCursor = true;

                LogInForm logInForm = new LogInForm(LoginInput.Text, PasswordInput.Text);
                Program.DI.Resolve<Session>().Update(await Program.DI.Resolve<LogInController>().LogIn(logInForm));

                UseWaitCursor = false;
                EnterSystem();
            }
            catch (ResponseException ex)
            {
                UseWaitCursor = false;
                MessageBox.Show(ex.message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnterSystem()
        {
            this.Visible = false;
            new PaymentInfoForm().ShowDialog();
            this.Visible = true;
        }
    }
}
