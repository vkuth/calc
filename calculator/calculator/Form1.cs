using System;
using System.Windows.Forms;
using calculator.OneArgumentCalvulator;
using calculator.TwoArgumentCalculator;

namespace calculator
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Method to support constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Acceptance of values and output of the result
        /// </summary>
        /// <param name="sender">Sending the name of the pressed button</param>
        /// <param name="e">Provides value for events that do not contain data</param>
        private void Calculete(object sender, EventArgs e)
        {
            try
            {
                double firstValue = Convert.ToDouble(textBox1.Text);
                double secondValue = Convert.ToDouble(textBox2.Text);
                ICalculator calculator = CalculatorFactory.CreateCalculator(((Button)sender).Name);
                var result = calculator.Calculate(firstValue, secondValue);
                textBox3.Text = result.ToString();
            }
            catch (Exception exp)
            {
                textBox3.Text = exp.Message;
            }
        }

        /// <summary>
        /// Acceptance of value and output of the result
        /// </summary>
        /// <param name="sender">Sending the name of the pressed button</param>
        /// <param name="e">Provides value for events that do not contain data</param>
        private void Sincos(object sender, EventArgs e)
        {
            try
            {
                double firstValue = Convert.ToDouble(textBox1.Text);
                IOneArgumentCalculator calculator = OneArgumentCalculatorFactory.CreateCalculator(((Button)sender).Name);
                var result = calculator.Calculate(firstValue);
                textBox3.Text = result.ToString();
            }
            catch (Exception exp)
            {
                textBox3.Text = exp.Message;
            }
        }

    }
}
