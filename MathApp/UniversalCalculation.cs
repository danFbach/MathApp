using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class UniversalCalculation
    {
        public double doMathWithList(List<string> numbers)
        {
            int i = 1;
            double nextNumber;
            double finalAnswer;
            bool finalAsnwerCheck = double.TryParse(numbers[0], out finalAnswer);
            if (!finalAsnwerCheck) { Console.WriteLine("Error."); return 0; }
            while (i < numbers.Count())
            {                
                Char opType = Convert.ToChar(numbers[i]);
                i++;
                bool checkDouble = double.TryParse(numbers[i], out nextNumber);
                if(!checkDouble) { Console.WriteLine("Error."); return 0; }                
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
                        Console.WriteLine("Error.");
                        return 0;
                }
            }
            return finalAnswer;
        }
    }
}