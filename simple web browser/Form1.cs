using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_web_browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("https://www.google.com/maps/place/");
            if (textBox1.Text != null)
            {
                sb.Append(textBox1.Text + "+" + ".");
                webBrowser1.Navigate(sb.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/maps/place/");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
