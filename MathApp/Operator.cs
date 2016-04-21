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
            Console.WriteLine("Please enter the operator of your choice. (+,-,/,*,^)");
            operatorChoice = Char.Parse(Console.ReadLine());
            return operatorChoice;
        }
    }
}
