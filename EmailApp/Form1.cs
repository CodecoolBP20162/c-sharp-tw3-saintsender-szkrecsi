using System;
using System.Windows.Forms;
using AE.Net.Mail;
using System.Collections.Generic;

namespace EmailApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getMessages();
        }

        private void getMessages() {

            string accessFile = @"self.txt";
            EmailClass access = new EmailClass();
            List<string> accessList = access.AccessReader(accessFile);
            string username = accessList[0];
            string password = accessList[1];

            ImapClient iclient = new ImapClient("imap.gmail.com", username, password, AuthMethods.Login, 993, true);
            iclient.SelectMailbox("inbox");
   
            MailMessage[] messages = iclient.GetMessages(0, 9, false);
            Array.Reverse(messages);
            int i = 0;
            string fileName = @"emailfile.dat";
            foreach (MailMessage message in messages)
            {
                dataMessages.Rows.Add("");
                dataMessages.Rows[i].Cells[0].Value = message.From;
                dataMessages.Rows[i].Cells[1].Value = message.Subject;
                dataMessages.Rows[i].Cells[2].Value = message.Body;
                dataMessages.Rows[i].Cells[3].Value = message.Date.ToShortDateString();
                
                EmailClass email = new EmailClass(message.From.ToString(), message.Subject.ToString(), message.Body.ToString(), message.Date.ToShortDateString());
                email.Serialize(fileName);
                i++;
            }
            iclient.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formNewMessage = new Form2();
            formNewMessage.Show();
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
        }
    }
}
