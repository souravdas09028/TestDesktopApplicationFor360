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
        }

        public  String op;

        public double result;


        Calculator basicCal = new Calculator();
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(txtVal1.Text != "" && txtVal2.Text != "" && txtOperator.Text != "")
            {
                basicCal.setVal1(Convert.ToDouble(txtVal1.Text));
                basicCal.setVal2(Convert.ToInt32(txtVal2.Text));
                op = txtOperator.Text;
                switch (op)
                {
                    case "+":
                        result = basicCal.addNum();
                        break;
                    case "-":
                        result = basicCal.subtNum();
                        break;
                    case "*":
                        result = basicCal.multNum();
                        break;
                    case "/":
                        result = basicCal.divNum();
                        break;

                    default:
                        break;
                }
                

                MessageBox.Show(result.ToString(), "Result", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show( "Please input both numbers and operator");
            }
           
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
