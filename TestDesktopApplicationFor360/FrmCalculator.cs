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
            txtVal1.Text = "0";
            txtVal2.Text = "0";
            resultBox.Text = "0";

        }

        private void btnAddition_Click(object sender, EventArgs e)
        {

            resultBox.Text = Calculation("add").ToString();

        }



        private void btnSubtract_Click(object sender, EventArgs e)
        {
            resultBox.Text = Calculation("subtract").ToString();

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            resultBox.Text = Calculation("multiply").ToString();

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            resultBox.Text = Calculation("divide").ToString();

        }

        private double Calculation(string oparation)
        {
            double result = 0;
            try
            {

                double num1 = Convert.ToDouble(txtVal1.Text);
                double num2 = Convert.ToDouble(txtVal2.Text);

                switch (oparation)
                {
                    case "add":
                        result = num1 + num2;
                        break;
                    case "subtract":
                        result = num1 - num2;
                        break;
                    case "multiply":
                        result = num1 * num2;
                        break;
                    case "divide":
                        result = num1 / num2;
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            MessageBox.Show("can not divide by zero");
                            return 0;

                        }
                        break;
                    default:
                        {
                            MessageBox.Show("error");
                            return 0;
                        }
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values.");
            }
            //catch (DivideByZeroException) {
            //    MessageBox.Show("can not divide by zero");
            //}
            return result;
        }

        private void txtVal1_Click(object sender, EventArgs e)
        {
            txtVal1.Clear();
        }

        private void txtVal2_Click(object sender, EventArgs e)
        {
            txtVal2.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVal1.Text = "0";
            txtVal2.Text = "0";
            resultBox.Text= "0";
        }
    }
}
