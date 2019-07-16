using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tb1 = Convert.ToDouble(textBox1.Text);
            double tb2 = Convert.ToDouble(textBox2.Text);
            double tb3 = tb1 + tb2;
            textBox3.Text = tb3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double tb1 = Convert.ToDouble(textBox1.Text);
            double tb2 = Convert.ToDouble(textBox2.Text);
            double tb3 = tb1 - tb2;
            textBox3.Text = tb3.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double tb1 = Convert.ToDouble(textBox1.Text);
            double tb2 = Convert.ToDouble(textBox2.Text);
            double tb3 = tb1 * tb2;
            textBox3.Text = tb3.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double tb1 = Convert.ToDouble(textBox1.Text);
            double tb2 = Convert.ToDouble(textBox2.Text);
            double tb3 = tb1 / tb2;
            textBox3.Text = tb3.ToString();
        }

       
    }
}
