using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb4._1
{
    public partial class Web : Form
    {
        public Web()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            button2.Enabled = webBrowser1.CanGoBack;
            button3.Enabled = webBrowser1.CanGoForward;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked )
            {
                button1.Click += button1_Click;
                webBrowser1.Url = new Uri("http://www.mon.gov.ua/");
            }
            else if(radioButton2.Checked)
            {
                button1.Click += button1_Click;
                webBrowser1.Url = new Uri("http://www.iteach.com.ua/");
            }
            else if (radioButton3.Checked)
            {
                button1.Click += button1_Click;
                webBrowser1.Url = new Uri("https://osvita.ua/");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 test = new Form1();
            test.Show();

        }
    }
}
