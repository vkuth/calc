using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calculator.OneArgumentCalvulator;
using calculator.TwoArgumentCalculator;

namespace calculator
{
    public partial class Form1 : Form
    {/// <summary>
    /// Метод для поддержки конструктора
    /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Принятие значений и вывод результата
        /// </summary>
        /// <param name="sender">Отправка условия нажатой кнопки</param>
        /// <param name="e">Предоставляет значение для событий, не содержащих данных</param>
        private void calculeted(object sender, EventArgs e)
        {
            try
            {
                double firstValue = Convert.ToDouble(textBox1.Text);
                double secondValue = Convert.ToDouble(textBox2.Text);
                ICalculator calculator = CalculatorFactory.CreateCalculator(((Button) sender).Name);
                var result = calculator.Calculate(firstValue, secondValue);
                textBox3.Text = result.ToString();
            }
            catch (Exception exp)
            {
                textBox3.Text = exp.Message;
            }
        }
        /// <summary>
        /// Принятие значения и вывод результата
        /// </summary>
        /// <param name="sender">Отправка условия нажатой кнопки</param>
        /// <param name="e">Предоставляет значение для событий, не содержащих данных</param>
        private void sincos(object sender, EventArgs e)
        {
            try
            {
                double firstValue = Convert.ToDouble(textBox1.Text);
                IOneArgumentCalculator calculator =OneArgumentCalculatorFactory.CreateCalculator(((Button) sender).Name);
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
