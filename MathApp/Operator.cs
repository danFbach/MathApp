using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class Operator
    {
        public Char getOperator()
        {
            Char operatorChoice;
            List<Char> possibleOperators = new List<char>() { '+', '-', '/', '*', '^' };
            Console.WriteLine("Please enter the operator of your choice. (+,-,/,*,^)");
            bool check = Char.TryParse(Console.ReadLine(), out operatorChoice);
            if (!check) { Console.WriteLine("Invalid entry. Please try again."); return getOperator(); }
            if (!possibleOperators.Contains(operatorChoice)) { Console.WriteLine("Invalid operator. Please re-enter selection."); }
            return operatorChoice;
        }
    }
}
