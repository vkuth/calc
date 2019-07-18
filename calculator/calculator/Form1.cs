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

        private void calculeted(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(textBox1.Text);
            double secondValue = Convert.ToDouble(textBox2.Text);
            ICalculator calculator = CalculatorFactory.CreateCalculator(((Button)sender).Name);
            var result = calculator.Calculate(firstValue, secondValue);
            textBox3.Text = result.ToString();
        }

        private void sincos(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(textBox1.Text);
            IOneArgumentCalculator calculator = OneArgumentCalculatorFactory.CreateCalculator(((Button)sender).Name);
            var result = calculator.Calculate(firstValue);
            textBox3.Text = result.ToString();
        }



    }
}
