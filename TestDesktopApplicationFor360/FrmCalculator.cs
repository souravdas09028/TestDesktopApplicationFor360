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

        string CalTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void button1_Click(object sender, EventArgs e)
        {
            textTotal.Text += btn1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textTotal.Text += btn2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textTotal.Text += btn3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textTotal.Text += btn4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textTotal.Text += btn5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textTotal.Text += btn6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textTotal.Text += btn7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textTotal.Text += btn8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textTotal.Text += btn9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textTotal.Text += btn0.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(textTotal.Text);

            textTotal.Clear();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(textTotal.Text);

            textTotal.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(textTotal.Text);

            textTotal.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(textTotal.Text);

            textTotal.Clear();
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textTotal.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            textTotal.Text = result + "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textTotal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}
