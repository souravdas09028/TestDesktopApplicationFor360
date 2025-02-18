using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesktopApplicationFor360
{
    public class Calculator
    {
        private double val1;
        private double val2;

        public void setVal1(double val)
        {
            val1 = val;
        }

        public void setVal2(double val)
        {
            val2 = val;
        }

        public double addNum()
        {

            return val1 + val2;
        }

        public double subtNum()
        {
            return val1 - val2;
        }

        public double multNum()
        {
            return val1 * val2;
        }

        public double divNum()
        {
            if (val1 != 0 && val2 != 0)
            {
                return val1 / val2;
            }
            else
            {
                MessageBox.Show("Invalid divission");
                return 0.0;
            }
        }
    }
}
