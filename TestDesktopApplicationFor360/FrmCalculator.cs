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

        public String op = "";

        public double result;

        public String totalInp;

        public String secInput;

        public double input1;





        Calculator basicCal = new Calculator();

        ScientificCalculator sciCal = new ScientificCalculator();

        public void setOp(String txt)
        {
            if (totalInp != "" && op == "")
            {
                op = "";
                op = txt;
                input1 = Convert.ToInt32(txtVal.Text);
                totalInp = txtVal.Text + op;
                txtVal.Text = totalInp;

            }


        }

        public void setInput1(String text)
        {
            txtVal.Clear();


            totalInp += text;
            txtVal.Text = totalInp;

        }

        public void setInput2(String text)
        {
            secInput += text;
            totalInp += text;
            txtVal.Text = totalInp;

        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            if ((txtVal != null || txtVal.Text != "" || txtVal.Text == null) && (secInput != null && secInput != ""))
            {
                basicCal.setVal1(input1);
                basicCal.setVal2(Convert.ToInt32(secInput));

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

                txtVal.Text = result.ToString();

                op = "";
                totalInp = "";
                secInput = "";
                input1 = 0.0;
                //MessageBox.Show(result.ToString(), "Result", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Please input numbers and operator");
            }

        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtVal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (input1 == null || input1 == 0.0)
            {
                setInput1("1");
            }
            else
            {
                setInput2("1");
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            setOp("+");
        }

        private void btnSubt_Click(object sender, EventArgs e)
        {
            setOp("-");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            setOp("*");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            setOp("/");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (input1 == null || input1 == 0.0)
            {
                setInput1("2");
            }
            else
            {
                setInput2("2");
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (input1 == null || input1 == 0.0)
            {
                setInput1("3");
            }
            else
            {
                setInput2("3");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (input1 == null || input1 == 0.0)
            {
                setInput1("4");
            }
            else
            {
                setInput2("4");
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (input1 == null || input1 == 0.0)
            {
                setInput1("5");
            }
            else
            {
                setInput2("5");
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (input1 == null || input1 == 0.0)
            {
                setInput1("6");
            }
            else
            {
                setInput2("6");
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {

            if (input1 == null || input1 == 0.0)
            {
                setInput1("7");
            }
            else
            {
                setInput2("7");
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (input1 == null || input1 == 0.0)
            {
                setInput1("8");
            }
            else
            {
                setInput2("8");
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (input1 == null || input1 == 0.0)
            {
                setInput1("9");
            }
            else
            {
                setInput2("9");
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (input1 == null || input1 == 0.0)
            {
                setInput1("0");
            }
            else
            {
                setInput2("0");
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            op = "";
            totalInp = "";
            secInput = "";
            input1 = 0.0;
            txtVal.Text = "";
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {

            if (txtVal.Text != null && txtVal.Text != "")
            {
                input1 = Convert.ToInt32(txtVal.Text);
                sciCal.setVal1(input1);
                result = sciCal.squareRootNum();
                txtVal.Text = result.ToString();

                op = "";
                totalInp = "";
                secInput = "";
                input1 = 0.0;
            }

        }

        private void btnSq_Click(object sender, EventArgs e)
        {
            if (txtVal.Text != null && txtVal.Text != "")
            {
                input1 = Convert.ToInt32(txtVal.Text);
                sciCal.setVal1(input1);
                result = sciCal.squareNum();
                txtVal.Text = result.ToString();

                op = "";
                totalInp = "";
                secInput = "";
                input1 = 0.0;
            }
        }

        private void btnCb_Click(object sender, EventArgs e)
        {
            if (txtVal.Text != null && txtVal.Text != "")
            {
                input1 = Convert.ToInt32(txtVal.Text);
                sciCal.setVal1(input1);
                result = sciCal.cubeNum();
                txtVal.Text = result.ToString();

                op = "";
                totalInp = "";
                secInput = "";
                input1 = 0.0;
            }
        }
    }
}
