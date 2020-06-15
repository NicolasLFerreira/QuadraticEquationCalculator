using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Equation_Calculator
{
    class ValueManager
    {

        //Checker

        public bool NullCheck(string input)
        {
            if (input == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
