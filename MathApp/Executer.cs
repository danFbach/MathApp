using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class Executer
    {
        public Numbers numbers = new Numbers();
        public Operator operation = new Operator();
        public Add add = new Add();
        public Subtract sub = new Subtract();
        public Divide divide = new Divide();
        public Multiply multiply = new Multiply();
        public Exponent power = new Exponent();
        public int answer;

        public void run()
        {
            int number1 = numbers.getFirstNumber();
            string opType = operation.getOperator();
            int number2 = numbers.getSecondNumber();

            if (opType.Equals("+"))
                {
                answer = add.Addition(number1, number2);
            }
            else if (opType.Equals("-")) 
                {
                answer = sub.Subtraction(number1, number2);
            }
            else if (opType.Equals("/")) 
                {
                answer = divide.division(number1, number2);
            }
            else if (opType.Equals("*")) 
                {
                answer = multiply.Multiplication(number1, number2);
            }
            else if (opType.Equals("^")) 
                {
                answer = power.Exponential(number1, number2);
            }
            Console.WriteLine(answer);

        }


    }
}
