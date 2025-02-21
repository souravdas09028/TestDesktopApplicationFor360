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
            ValueRefresher();
            UiValueRefresher();

        }

        double num1 = 0;
        double num2 = 0;
        double result = 0;
        bool isValid = true;
        List<string> history = new List<string>();

        Calculator calculator = new Calculator();
        ScntfcCalculator scntfcCalculator = new ScntfcCalculator();


        private void txtNumInput_Click(object sender, EventArgs e)
        {
            txtNumInput.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GetNum1();
            calculator.oprtr = "+";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ValueRefresher();
            UiValueRefresher();
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

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            if (Validator())
            {
                num2 = calculator.number;
                result = calculator.Calculation(num1, num2, calculator.oprtr);
                resultBox.Text = result.ToString();

                string entry = $"{num1} {calculator.oprtr} {num2} = {result}";
                history.Add(entry);
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values.");
            }

        }

        private void btnSqrRoot_Click(object sender, EventArgs e)
        {
            scntfcCalculator.number = Convert.ToDouble(txtNumInput.Text);
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

        private void GetNum1()
        {
            if(Validator())
            {
                num1 = calculator.number;
                UiValueRefresher();
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values.");
            }

        }


        private bool Validator()
        {
            try
            {
                calculator.number = Convert.ToDouble(txtNumInput.Text);
                return isValid;
            }
            catch (FormatException)
            {
                return isValid = false;
            }
        }

        private void UiValueRefresher()
        {
            txtNumInput.Text = "0";
            resultBox.Text = "0";
            calculator.number = 0;
        }

        private void ValueRefresher()
        {
            num1 = 0;
            num2 = 0;
            result = 0;
            history.Clear();
        }
    }
}
