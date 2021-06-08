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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                Test2 test = new Test2();
                test.Show();
           
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Web test = new Web();
            test.Show();
        }
    }
}
