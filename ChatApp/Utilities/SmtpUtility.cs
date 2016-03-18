using ChatApp.Controls;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp.Utilities
{
    class SmtpUtility
    {
        private const string HOST = "smtp.gmail.com";
        private const int PORT = 587;
        private const string USERNAME = "noreply.chat.app";
        private const string PASSWORD = "jayarn66";
        private const string FROM = USERNAME + "@gmail.com";

        public delegate void OnException(SmtpException e);

        public static async Task<bool> Send(string recipients, string subject, string body, OnException onException)
        {
            try
            {
                using (SmtpClient smtpClient = new SmtpClient(HOST, PORT))
                {
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(USERNAME, PASSWORD);
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    await smtpClient.SendMailAsync(FROM, recipients, "[" + ChatAppForm.TITLE + "] " + subject, body);
                    return true;
                }
            }
            catch (SmtpException e)
            {
                Console.WriteLine(e);

                if (onException != null)
                {
                    onException(e);
                }

                MessageBox.Show("Connection unavailable!", ChatAppForm.TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
    }
}
