using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class Executer
    {
        Numbers numbers = new Numbers();
        UniversalCalculation universalCalculation = new UniversalCalculation();
        List<String> newOperation = new List<String>();
        double answer = 0;

        public void run()
        {
            bool calculateAgain = true;
            while (calculateAgain)
            {
                newOperation = numbers.getNumberString();
                answer = universalCalculation.doMathWithList(newOperation);
                Console.WriteLine(answer);
                calculateAgain = newCalculation();
                Console.Clear();
            }
        }
        public bool newCalculation()
        {
            Char[] yes = { 'y', 'Y' };
            Char[] no = { 'n', 'N' };
            Char answer;
            Console.WriteLine("Do you need to make another calculation? (Y/N)");
            bool check = Char.TryParse(Console.ReadLine(), out answer);
            if (!check) { Console.WriteLine("Invalid Characters."); return newCalculation(); }
            if (yes.Contains(answer))
            {
                return true;
            }
            else if (no.Contains(answer))
            {
                return false;
            }
            else { Console.WriteLine("Invalid selection, please re-enter"); return newCalculation(); }
        }
    }
}