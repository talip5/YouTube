using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youTube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(10, 10);
            this.Width=1800;
            this.Height = 1000;

            int webBrowser_width = this.Width;
            int webBrowser_height = this.Height;

            comboBox1.Items.Add("https://www.microsoft.com/tr-tr/microsoft-365/microsoft-office");
            comboBox1.Items.Add("https://www.microsoft.com/tr-tr/microsoft-365/free-office-online-for-the-web");

            webBrowser1.Location = new Point(10, 100);
            webBrowser1.Height = webBrowser_height-160;
            webBrowser1.Width = webBrowser1.Width-100;
            webBrowser1.Navigate("https://www.google.com.tr/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com.tr/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(comboBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
