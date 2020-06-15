using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace Quadratic_Equation_Calculator
{
    class Equation
    {

        public double[] QuadraticEquation(double a, double b, double c)
        {

            /*
             * Math
             */

            //Delta

            double deltaComp1 = Math.Pow(b, 2);
            double deltaComp2 = (4 * (a * c));
            double deltaFinal = Math.Sqrt(deltaComp1 - deltaComp2);

            //Lower part

            double downPart = 2 * a;

            //Top part

            double topPart1 = (-b + deltaFinal);
            double topPart2 = (-b - deltaFinal);

            //Results

            double result1 = topPart1 / downPart;

            double result2 = topPart2 / downPart;

            //Excepetion

            double error = 0;

            if (double.IsNaN(deltaFinal))
            {
                error = 1;
            }

            //Return

            double[] returnValues = { result1, result2, deltaComp1, deltaComp2, error};

            return returnValues;
        }
    }
}
