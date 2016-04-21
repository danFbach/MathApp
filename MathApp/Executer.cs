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
        UniversalCalculation universalCalculation = new UniversalCalculation();
        double answer1 = 0;
        double answer2 = 0;

        public void run()
        {
            double number1 = numbers.getFirstNumber();
            Char opType = operation.getOperator();
            double number2 = numbers.getSecondNumber();

            answer1 = universalCalculation.genericCalculator(number1,number2,opType);

            if (opType.Equals('+'))
            {
                answer2 = add.Addition(number1, number2);
            }
            else if (opType.Equals('-'))
            {
                answer2 = sub.Subtraction(number1, number2);
            }
            else if (opType.Equals('/'))
            {
                answer2 = divide.division(number1, number2);
            }
            else if (opType.Equals('*'))
            {
                answer2 = multiply.Multiplication(number1, number2);
            }
            else if (opType.Equals('^'))
            {
                answer2 = power.Exponential(number1, number2);
            }
            Console.WriteLine("Factory pattern: \n\rThe answer to {0} {1} {2} is {3}.\n\r", number1, opType, number2, answer2);

            Console.WriteLine("Dependancy injection: \n\rThe answer to {0} {1} {2} is {3}.", number1, opType, number2, answer1);
        }
    }
}