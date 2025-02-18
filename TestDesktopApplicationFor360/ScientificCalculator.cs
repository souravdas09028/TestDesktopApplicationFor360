using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesktopApplicationFor360
{
  public  class ScientificCalculator : Calculator
    {

   
     
        
        public double squareRootNum()  
        {
            return Math.Sqrt(val1);
        }

        public double squareNum() 
        {
            return Math.Pow(val1, 2);
        }
    }
}
