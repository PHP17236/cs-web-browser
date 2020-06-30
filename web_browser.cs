using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser2.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser2.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser2.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser2.Stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("http://lonely.sahinler-insaat.com");
        }
    }
 }
