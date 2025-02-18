using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDesktopApplicationFor360
{

    public partial class FrmCalculator : Form
    {


        public FrmCalculator()
        {
            InitializeComponent();
            numBox.Text = "0";

        }

        double num1 = 0;
        double num2 = 0;
        double result = 0;
        List<string> history = new List<string>();


        private class Calculator
        {
            public double number;
            public string oprtr;

            public double Calculation(double nmbr1, double nmbr2, string sign)
            {

                switch (sign)
                {
                    case "+":
                        return nmbr1 + nmbr2;
                    case "-":
                        return nmbr1 - nmbr2;
                    case "*":
                        return nmbr1 * nmbr2;
                    case "/":
                        if (nmbr2 == 0)
                            MessageBox.Show("can not divide by zero");
                        return nmbr1 / nmbr2;
                    default: return 0;
                }


            }

        }

        Calculator calculator = new Calculator();


        private void numBox_Click(object sender, EventArgs e)
        {
            numBox.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GetNum1();
            calculator.oprtr = "+";
        }


        private void btnCalculation_Click(object sender, EventArgs e)
        {
            try
            {
                calculator.number = Convert.ToDouble(numBox.Text);
                num2 = calculator.number;
                result = calculator.Calculation(num1, num2, calculator.oprtr);
                resultBox.Text = result.ToString();

                string entry = $"{num1} {calculator.oprtr} {num2} = {result}";
                history.Add(entry);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values.");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            result = 0;
            numBox.Text = "0";
            resultBox.Text = "0";
            calculator.number = 0;
            history.Clear();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            GetNum1();
            calculator.oprtr = "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            GetNum1();
            calculator.oprtr = "*";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            GetNum1();
            calculator.oprtr = "/";
        }

        private void GetNum1()
        {
            try
            {
                calculator.number = Convert.ToDouble(numBox.Text);
                num1 = calculator.number;
                calculator.number = 0;
                numBox.Text = "0";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values.");
            }

        }

        private class ScntfcCalculator : Calculator
        {
            public double SqrRoot(double nmbr)
            {
                if (nmbr <= 0)
                    MessageBox.Show("enter valid numeric number greater than zero");
                return Math.Sqrt(nmbr);
            }
        }

        ScntfcCalculator scntfcCalculator = new ScntfcCalculator();

        private void btnSqrRoot_Click(object sender, EventArgs e)
        {
            scntfcCalculator.number = Convert.ToDouble(numBox.Text);
            num1 = scntfcCalculator.number;
            scntfcCalculator.oprtr = "√";
            result = scntfcCalculator.SqrRoot(num1);
            resultBox.Text = result.ToString();

            string entry = $"{scntfcCalculator.oprtr} {num1} = {result}";
            history.Add(entry);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (history.Count == 0)
            {
                MessageBox.Show("No history available.", "History", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string historyText = string.Join("\n", history);
                MessageBox.Show(historyText, "Calculation History", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
