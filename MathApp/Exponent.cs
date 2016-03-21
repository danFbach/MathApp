using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class Exponent
    {
        public double answer;
        public double Exponential(double number1, double number2)
        {
            answer = Math.Pow(number1, number2);
            return answer;
        }
    }
}
