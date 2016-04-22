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
        Operator operation = new Operator();
        Add add = new Add();
        Subtract sub = new Subtract();
        Divide divide = new Divide();
        Multiply multiply = new Multiply();
        Exponent power = new Exponent();
        UniversalCalculation universalCalculation = new UniversalCalculation();
        List<String> newOperation = new List<String>();
        double answer1 = 0;
        double answer2 = 0;
        double answer3 = 0;

        public void run()
        {
            bool calculateAgain = true;
            while (calculateAgain)
            {
                newOperation = numbers.getNumberString();
                //double number1 = numbers.getFirstNumber();
                //Char opType = operation.getOperator();
                //double number2 = numbers.getSecondNumber();


                //answer1 = universalCalculation.genericCalculator(number1, number2, opType);
                answer3 = universalCalculation.doMathWithList(newOperation);

                //if (opType.Equals('+'))
                //{
                //    answer2 = add.Addition(number1, number2);
                //}
                //else if (opType.Equals('-'))
                //{
                //    answer2 = sub.Subtraction(number1, number2);
                //}
                //else if (opType.Equals('/'))
                //{
                //    answer2 = divide.division(number1, number2);
                //}
                //else if (opType.Equals('*'))
                //{
                //    answer2 = multiply.Multiplication(number1, number2);
                //}
                //else if (opType.Equals('^'))
                //{
                //    answer2 = power.Exponential(number1, number2);
                //}
                //Console.WriteLine("Factory pattern: \n\rThe answer to {0} {1} {2} is {3}.\n\r", number1, opType, number2, answer2);
                //Console.WriteLine("Dependancy injection: \n\rThe answer to {0} {1} {2} is {3}.", number1, opType, number2, answer1);
                Console.WriteLine(answer3);
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