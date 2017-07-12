using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage(); //from, to, subject, message
                SmtpClient SmtpServer = new SmtpClient(); //host

                mail.From = new MailAddress("ycarecoder@gmail.com");
                string mailTo = txtTo.Text;
                mail.To.Add(mailTo);
                string mailSubject = txtSubject.Text;
                mail.Subject = mailSubject;
                string mailMessage = txtMessage.Text;
                mail.Body = mailMessage;

                SmtpServer.Port = 587;
                SmtpServer.Host = "smtp.gmail.com";
                SmtpServer.Credentials = new System.Net.NetworkCredential("ycarecoder", "codecool");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Email Sent Successfully!", "Message from App", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc) { }
        }
    }
}
