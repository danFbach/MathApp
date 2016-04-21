using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class UniversalCalculation
    {
        public double genericCalculator(double number1, double number2, Char opType)
        {
            double newNumber = 0;
            switch (opType)
            {
                case ('+'):
                    newNumber = number1 + number2;
                    return newNumber;
                case ('-'):
                    newNumber = number1 - number2;
                    return newNumber;
                case ('*'):
                    newNumber = number1 * number2;
                    return newNumber;
                case ('/'):
                    newNumber = number1 / number2;
                    return newNumber;
                case ('^'):
                    newNumber = Math.Pow(number1, number2);
                    return newNumber;
                default:
                    return newNumber;
            }            
        }
    }
}
