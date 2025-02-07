namespace TestDesktopApplicationFor360
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int val1 = Convert.ToInt32(txtVal1.Text);
            int val2 = Convert.ToInt32(txtVal2.Text);

            int sum = val1 + val2;

            MessageBox.Show(sum.ToString(),"Result", MessageBoxButtons.OK);
        }
    }
}
