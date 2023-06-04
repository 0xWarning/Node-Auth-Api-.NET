using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NABAP.AuthAPI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace NABAP
{
    public partial class Form1 : Form
    {
        private AuthAPI AAPI = new AuthAPI();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AAPI.Login(logEmailEdit.Text, logPassEdit.Text))
            {
                label2.Text = "Logged In <3";
                label1.Text = "Grabbed login info :)";
                textBox1.Text = "Token > " + UserLoggedInfo.token;
                textBox2.Text = "Email > " + UserLoggedInfo.email;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AAPI.Register(regNameEdit.Text, regEmailEdit.Text, regPassEdit.Text, regLicenseKey.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AAPI.CreateLicense(textBox7.Text, textBox8.Text, textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AAPI.RemoveUser(textBox5.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (AAPI.LoginToken(textBox4.Text))
            {
                label2.Text = "Logged In <3";
                label1.Text = "Grabbed login info :)";
                textBox1.Text = "Token > " + UserLoggedInfo.token;
                textBox2.Text = "License > " + UserLoggedInfo.license;
            }
        }
    }
}
