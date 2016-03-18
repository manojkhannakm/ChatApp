using ChatApp.Utilities;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChatApp.Controls.SignIn.ForgotPassword
{
    public partial class PasswordPage : Page
    {
        private string email;

        public PasswordPage()
        {
            InitializeComponent();
        }

        public PasswordPage(string email)
        {
            this.email = email;

            InitializeComponent();
        }

        private void PasswordPage_Load(object sender, System.EventArgs e)
        {
            ParentForm.CancelButton = cancelButton;

            ActiveControl = newPasswordTextBox;
        }

        private bool Validate(TextBox textBox, bool[] conditions, string[] errorTexts)
        {
            for (int i = 0; i < conditions.Length; i++)
            {
                if (conditions[i])
                {
                    textBox.BackColor = Color.LightCoral;
                    errorToolTip.SetToolTip(textBox, errorTexts[i]);

                    resetButton.Enabled = false;
                    return false;
                }
            }

            textBox.BackColor = Color.LightGreen;
            errorToolTip.SetToolTip(textBox, null);

            if (newPasswordTextBox.BackColor != Color.LightCoral
                && confirmPasswordTextBox.BackColor != Color.LightCoral)
            {
                resetButton.Enabled = true;
            }

            return true;
        }

        private bool Validate(TextBox textBox, bool condition, string errorText)
        {
            return Validate(textBox, new bool[] { condition }, new string[] { errorText });
        }

        private void newPasswordTextBox_TextChanged(object sender, System.EventArgs e)
        {
            confirmPasswordTextBox.Text = null;
            confirmPasswordTextBox.BackColor = SystemColors.Window;
            errorToolTip.SetToolTip(confirmPasswordTextBox, null);

            string newPassword = newPasswordTextBox.Text;
            if (Validate(newPasswordTextBox, newPassword.Length < 6, "Password should have at least 6 characters!"))
            {
                switch (Convert.ToInt32(Regex.IsMatch(newPassword, "[a-zA-Z]+"))
                    + Convert.ToInt32(Regex.IsMatch(newPassword, "[0-9]+"))
                    + Convert.ToInt32(Regex.IsMatch(newPassword, "[^a-zA-Z0-9]+")))
                {

                    case 1:
                        newPasswordTextBox.BackColor = Color.Khaki;
                        break;

                    case 2:
                        newPasswordTextBox.BackColor = Color.LightBlue;
                        break;

                    case 3:
                        newPasswordTextBox.BackColor = Color.LightGreen;
                        break;

                }
            }
        }

        private void confirmPasswordTextBox_TextChanged(object sender, System.EventArgs e)
        {
            string confirmPassword = confirmPasswordTextBox.Text;
            Validate(confirmPasswordTextBox,
                new bool[] {
                    confirmPassword.Length < 6,
                    !confirmPassword.Equals(newPasswordTextBox.Text)
                },
                new string[] {
                    "Confirm password should have at least 6 characters!",
                    "Confirm password should match password!"
                });
        }

        private void StopLoading()
        {
            loadingPictureBox.Visible = false;
            loadingPictureBox.Stop();
            resetButton.Visible = true;
            cancelButton.Visible = true;
        }

        private async void resetButton_Click(object sender, System.EventArgs e)
        {
            resetButton.Visible = false;
            cancelButton.Visible = false;
            loadingPictureBox.Start();
            loadingPictureBox.Visible = true;

            if (await SqlUtility.Write("UPDATE [users] SET [password] = @password WHERE [email] = @email;",
                new string[] { newPasswordTextBox.Text, email }, delegate(SqlException ex)
                {
                    StopLoading();
                }) != 1)
            {
                return;
            }

            StopLoading();
            MessageBox.Show("Password reset successful!", ChatAppForm.TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            ParentForm.Dispose();
        }
    }
}
