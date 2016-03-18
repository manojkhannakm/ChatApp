using System.Windows.Forms;

namespace ChatApp.Controls.SignUp
{
    public partial class EmailVerificationForm : Form
    {
        private string verificationCode;

        public EmailVerificationForm()
        {
            InitializeComponent();
        }

        public EmailVerificationForm(string verificationCode)
        {
            this.verificationCode = verificationCode;

            InitializeComponent();
        }

        private void verificationCodeTextBox_TextChanged(object sender, System.EventArgs e)
        {
            verifyButton.Enabled = verificationCodeTextBox.Text.Length > 0;
        }

        private void verifyButton_Click(object sender, System.EventArgs e)
        {
            if (!verificationCodeTextBox.Text.Equals(verificationCode))
            {
                MessageBox.Show("Incorrect verification code!", ChatAppForm.TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }
    }
}
