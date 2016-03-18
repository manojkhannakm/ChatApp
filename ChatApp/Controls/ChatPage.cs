using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChatApp.Controls
{
    public partial class ChatPage : Page
    {
        private string name;

        public ChatPage()
        {
            InitializeComponent();
        }

        public ChatPage(string name)
        {
            this.name = name;

            InitializeComponent();

            welcomeLabel.Text = "Welcome " + name + "!";
        }

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {
            sendButton.Enabled = messageTextBox.Text.Length > 0;
        }


    }
}
