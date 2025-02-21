using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesktopApplicationFor360
{
    public class Calculator
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

    public class ScntfcCalculator : Calculator
    {
        public double SqrRoot(double nmbr)
        {
            if (nmbr < 0)
                MessageBox.Show("enter valid numeric number greater than zero");
            return Math.Sqrt(nmbr);
        }
    }
}
