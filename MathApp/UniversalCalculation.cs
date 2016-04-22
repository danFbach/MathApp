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
        public double doMathWithList(List<string> numbers)
        {
            int i = 1;
            double finalAnswer = Convert.ToDouble(numbers[0]);
            while(i < numbers.Count())
            {
                
                Char opType = Convert.ToChar(numbers[i]);
                i++;
                double nextNumber = Convert.ToDouble(numbers[i]);
                switch (opType)
                {
                    case ('+'):
                        finalAnswer += nextNumber;
                        i++;
                        break;
                    case ('-'):
                        finalAnswer -= nextNumber;
                        i++;
                        break;
                    case ('*'):
                        finalAnswer *= nextNumber;
                        i++;
                        break;
                    case ('/'):
                        finalAnswer /= nextNumber;
                        i++;
                        break;
                    case ('^'):
                        finalAnswer = Math.Pow(finalAnswer, nextNumber);
                        i++;
                        break;
                    default:
                        break;
                }
            }            
            return finalAnswer;
        }
    }
}