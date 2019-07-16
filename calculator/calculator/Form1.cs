﻿using System;
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
            double firstvalue = Convert.ToDouble(textBox1.Text);
            double secondvalue = Convert.ToDouble(textBox2.Text);
            double result;
            ICalculator calculator = CalculatorFactory.CreateCalculator(((Button)sender).Name);
            result = calculator.Calculate(firstvalue, secondvalue);
            textBox3.Text = result.ToString();
        }

       

       
    }
}