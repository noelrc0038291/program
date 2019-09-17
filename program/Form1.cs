using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double pi = 3.141592653589793;
            double c = 299792458;
            richTextBox1.AppendText(pi.ToString("N3") + "\n");
            richTextBox1.AppendText(pi.ToString("N5") + "\n");
            richTextBox1.AppendText(pi.ToString("N15") + "\n");
            richTextBox1.AppendText(pi.ToString() + "\n");
            richTextBox1.AppendText(pi.ToString("N") + "\n");
            richTextBox1.AppendText(pi.ToString("0.000000000000000e0") + "\n");
            richTextBox1.AppendText(pi.ToString("0.00e0") + "\n");
        }

        private void AppendText(object p, object n, char v)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
