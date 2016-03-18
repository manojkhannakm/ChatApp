using ChatApp.Controls.SignIn.ForgotPassword;
using ChatApp.Controls.SignUp;
using ChatApp.Properties;
using ChatApp.Utilities;
using System;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChatApp.Controls.SignIn
{
    public partial class SignInPage : Page
    {
        private bool signingIn = false;

        public SignInPage()
        {
            InitializeComponent();

            StringCollection autoCompleteEmails = Settings.Default.AutoCompleteEmails;
            if (autoCompleteEmails != null)
            {
                AutoCompleteStringCollection emails = new AutoCompleteStringCollection();
                foreach (string email in autoCompleteEmails)
                {
                    emails.Add(email);
                }
                emailTextBox.AutoCompleteCustomSource = emails;
            }

            string signedInCredentials = Settings.Default.SignedInCredentials;
            if (signedInCredentials.Length > 0)
            {
                string[] credentials = signedInCredentials.Split(' ');
                emailTextBox.Text = credentials[0];
                passwordTextBox.Text = credentials[1];

                keepMeSignedInCheckBox.CheckState = CheckState.Checked;
            }
        }

        private void SignInPage_Load(object sender, EventArgs e)
        {
            ActiveControl = emailTextBox;

            if (keepMeSignedInCheckBox.CheckState == CheckState.Checked)
            {
                SignIn();
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            signInButton.Enabled = emailTextBox.Text.Length > 0 && passwordTextBox.Text.Length > 0;
        }

        private void StopLoading()
        {
            loadingPictureBox.Visible = false;
            loadingPictureBox.Stop();
            signInButton.Visible = true;
            signUpButton.Enabled = true;

            signingIn = false;
        }

        private async void SignIn()
        {
            if (!signInButton.Enabled || signingIn)
            {
                return;
            }

            signingIn = true;

            signInButton.Visible = false;
            signUpButton.Enabled = false;
            loadingPictureBox.Start();
            loadingPictureBox.Visible = true;

            string email = emailTextBox.Text,
                password = passwordTextBox.Text;
            using (SqlDataReader dataReader = await SqlUtility.Read("SELECT [name], [password] FROM [users] WHERE [email] = @email;",
                new string[] { email }, delegate(SqlException e)
                {
                    StopLoading();
                }))
            {
                if (dataReader == null)
                {
                    return;
                }

                if (!await dataReader.ReadAsync() || !dataReader.GetString(1).Equals(password))
                {
                    StopLoading();
                    MessageBox.Show("Incorrect credentials!", ChatAppForm.TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Settings.Default.AutoCompleteEmails == null)
                {
                    Settings.Default.AutoCompleteEmails = new StringCollection();
                }
                Settings.Default.AutoCompleteEmails.Add(email);

                if (keepMeSignedInCheckBox.CheckState == CheckState.Checked)
                {
                    Settings.Default.SignedInCredentials = email + " " + password;
                }
                else
                {
                    Settings.Default.SignedInCredentials = "";
                }

                Settings.Default.Save();

                StopLoading();
                SwitchTo(new ChatPage(dataReader.GetString(0)), SWITCH_LEFT);
            }
        }

        private void emailTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = e.SuppressKeyPress = true;

                SignIn();
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            signInButton.Enabled = emailTextBox.Text.Length > 0 && passwordTextBox.Text.Length > 0;
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = e.SuppressKeyPress = true;

                SignIn();
            }
        }

        private void forgotPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (signingIn)
            {
                return;
            }

            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.ShowDialog();
            forgotPasswordForm.Dispose();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            SignIn();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SwitchTo(new SignUpPage(), SWITCH_LEFT);
        }
    }
}
