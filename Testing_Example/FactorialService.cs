using System;
using System.Collections.Generic;
using System.Text;

namespace Testing_Example
{
  public  class FactorialService
    {

        public int Calculate (int number)
        {
            if(number==0)
            {
                return 1;

            }
            return number * Calculate(number - 1);
   //
        }
    }

}


