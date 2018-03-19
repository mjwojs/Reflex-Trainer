using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net; 

namespace reflexTrainer
{
    public partial class Form6 : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login = new NetworkCredential(textUser.Text, textPass.Text);
            client = new SmtpClient(textSmtp.Text);
            client.Port = Convert.ToInt32(textPort.Text);
            client.EnableSsl = checkSsl.Checked;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress(textUser.Text + textSmtp.Text.Replace("smtp.", "@"), "Reflex Trainer - kontakt", Encoding.UTF8) };
            msg.To.Add(new MailAddress("wojs.michal@gmail.com"));
            msg.Subject = textSub.Text;
            msg.Body = textCon.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            string userstate = "Wysyłanie w toku...";
            client.SendAsync(msg, userstate);
        }

        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {    
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Wiadomość", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Wiadomość wysłana!", "Wiadomość", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
