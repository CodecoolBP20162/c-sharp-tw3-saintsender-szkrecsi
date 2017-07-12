using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace EmailApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formNewMessage = new Form2();
            formNewMessage.Show();
        }
    }
}
