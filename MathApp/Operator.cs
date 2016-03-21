using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class Operator
    {
        public String getOperator()
        {
            String operatorChoice;
            Console.WriteLine("Please enter the operator of your choice. (+,-,/,*,^)");
            operatorChoice = Console.ReadLine();
            return operatorChoice;
        }
    }
}
