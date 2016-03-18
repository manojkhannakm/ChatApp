using System.Windows.Forms;

namespace ChatApp.Controls.SignIn.ForgotPassword
{
    public partial class ResetCodePage : Page
    {
        private string email, resetCode;

        public ResetCodePage()
        {
            InitializeComponent();
        }

        public ResetCodePage(string email, string resetCode)
        {
            this.email = email;
            this.resetCode = resetCode;

            InitializeComponent();
        }

        private void ResetCodePage_Load(object sender, System.EventArgs e)
        {
            ParentForm.CancelButton = cancelButton;

            ActiveControl = resetCodeTextBox;
        }

        private void resetCodeTextBox_TextChanged(object sender, System.EventArgs e)
        {
            verifyButton.Enabled = resetCodeTextBox.Text.Length > 0;
        }

        private void verifyButton_Click(object sender, System.EventArgs e)
        {
            if (!resetCodeTextBox.Text.Equals(resetCode))
            {
                MessageBox.Show("Incorrect reset code!", ChatAppForm.TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SwitchTo(new PasswordPage(email), SWITCH_LEFT);
        }
    }
}
