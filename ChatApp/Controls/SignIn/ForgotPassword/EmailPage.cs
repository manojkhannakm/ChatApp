using ChatApp.Utilities;
using System;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Windows.Forms;

namespace ChatApp.Controls.SignIn.ForgotPassword
{
    public partial class EmailPage : Page
    {
        public EmailPage()
        {
            InitializeComponent();
        }

        private void EmailPage_Load(object sender, System.EventArgs e)
        {
            ParentForm.CancelButton = cancelButton;

            ActiveControl = emailTextBox;
        }

        private void emailTextBox_TextChanged(object sender, System.EventArgs e)
        {
            okButton.Enabled = emailTextBox.Text.Length > 0;
        }

        private void StopLoading()
        {
            loadingPictureBox.Visible = false;
            loadingPictureBox.Stop();
            okButton.Visible = true;
            cancelButton.Visible = true;
        }

        private async void okButton_Click(object sender, System.EventArgs e)
        {
            okButton.Visible = false;
            cancelButton.Visible = false;
            loadingPictureBox.Start();
            loadingPictureBox.Visible = true;

            string email = emailTextBox.Text;
            using (SqlDataReader dataReader = await SqlUtility.Read("SELECT [email], [name] FROM [users] WHERE [email] = @email;",
                new string[] { email }, delegate(SqlException ex1)
                {
                    StopLoading();
                }))
            {
                if (dataReader == null)
                {
                    return;
                }

                if (!await dataReader.ReadAsync())
                {
                    StopLoading();
                    MessageBox.Show("Email not linked to any account!", ChatAppForm.TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string resetCode = new Random().Next(0x100000, 0xffffff + 1).ToString("X").ToLower();
                if (!await SmtpUtility.Send(email, "Password reset",
                    "Hello " + dataReader.GetString(1) + ",\n\n"
                    + "Please use the following reset code to reset the password of your account.\n\n"
                    + "Reset code: #" + resetCode, delegate(SmtpException ex2)
                    {
                        StopLoading();
                    }))
                {
                    return;
                }

                StopLoading();
                SwitchTo(new ResetCodePage(email, resetCode), SWITCH_LEFT);
            }
        }
    }
}
