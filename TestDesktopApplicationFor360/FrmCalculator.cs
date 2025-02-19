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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int val1 = Convert.ToInt32(txtVal1.Text);
            int val2 = Convert.ToInt32(txtVal2.Text);
            var opt = txtVal3.Text;
            double result = 0;
            switch (opt)
            {
                case "+":
                    result = val1 + val2;
                    break;
                case "-":
                    result = val1 - val2;
                    break;
                case "*":
                    result = val1 * val2;
                    break;
                case "/":
                    result = val1 / val2;
                    break;
                default:
                    MessageBox.Show("Invalid Operation", "Warning", MessageBoxButtons.OK);
                    break;

            }

            MessageBox.Show(result.ToString(), "Result", MessageBoxButtons.OK);
        }
    }
}