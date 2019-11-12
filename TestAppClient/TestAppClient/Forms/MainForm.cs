using System;
using System.Windows.Forms;

using Autofac;

using TestAppClient.Model;
using TestAppClient.Controllers;
using TestAppClient.ServerAccess.Impl;
using TestAppClient.Util.Validation.Templates;

namespace TestAppClient.Forms
{
    public partial class MainForm : Form
    {
        private static AuthFormValidator<Control> FormValidator { get; set; }

        public MainForm()
        {
            InitializeComponent();
            FormValidator = new AuthFormValidator<Control>(LoginInput, PasswordInput);
        }

        private async void SignUpButton_Click(object sender, EventArgs e)
        {
            if (!FormValidator.ValidateAll())
            {
                MessageBox.Show("Invalid data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                UseWaitCursor = true;

                SignUpForm signUpForm = new SignUpForm(LoginInput.Text, PasswordInput.Text);
                Program.DI.Resolve<Session>().Update(await Program.DI.Resolve<AuthController>().SignUp(signUpForm));

                UseWaitCursor = false;
                MessageBox.Show("Registration successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetCredentials();
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
            if (!FormValidator.ValidateAll())
            {
                MessageBox.Show("Invalid data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                UseWaitCursor = true;

                LogInForm logInForm = new LogInForm(LoginInput.Text, PasswordInput.Text);
                Program.DI.Resolve<Session>().Update(await Program.DI.Resolve<AuthController>().LogIn(logInForm));

                UseWaitCursor = false;

                ResetCredentials();
                EnterSystem();
            }
            catch (ResponseException ex)
            {
                UseWaitCursor = false;
                MessageBox.Show(ex.message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetCredentials()
        {
            LoginInput.ResetText();
            PasswordInput.ResetText();
        }

        private void EnterSystem()
        {
            this.Visible = false;
            new PaymentInfoForm().ShowDialog();
            this.Visible = true;
        }
    }
}
