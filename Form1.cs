using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void gonder_Click(object sender, EventArgs e)
        {
            string k_adi = textUserN.Text;
            string sifre = textSifre.Text;

            if (k_adi == "admin" && sifre == "admin")
            {
                MessageBox.Show("Kullanıcı Adı ve şifreniz doğru. Sisteme Yönlendiriliyorsunuz.", "Info" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start("http://localhost");
                Application.Exit();
            }
            else if(k_adi == "" || sifre == "")
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş bırakılmaz.","Info",MessageBoxButtons.RetryCancel,MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Error ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                label.Text = "Kullanıcı Adınızı Veya şifrenizi yanlış girdiğiniz için bloklandınız.";
                gonder.Visible = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
