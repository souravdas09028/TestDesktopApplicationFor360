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

            int sum = val1 + val2 + 5;

            MessageBox.Show(sum.ToString(), "Result", MessageBoxButtons.OK);
        }
    }
}
