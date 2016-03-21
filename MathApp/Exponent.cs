using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class Exponent
    {
        public int answer;
        public int Exponential(int number1, int number2)
        {
            int newNumber = number1 * number1;
            int count = number2 - 2;
            if (count > 0)
            {
                newNumber = (newNumber * number1);
                count--;
            }
            answer = newNumber;
            return answer;
        }
    }
}
