using ChatApp.Controls.SignIn;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp.Controls
{
    public partial class ChatAppForm : Form
    {
        public const string TITLE = "Chat App";

        public ChatAppForm()
        {
            InitializeComponent();
        }

        private async void ChatAppForm_Load(object sender, EventArgs e)
        {
            await Task.Delay(1500);

            splashPage.SwitchTo(new SignInPage(), Page.SWITCH_LEFT);
        }
    }
}
