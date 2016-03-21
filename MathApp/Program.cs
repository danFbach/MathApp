using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take in a user input that consists of two numbers and an operator
            //Calculate Addition, Subtraction, Multiplication, Division, Exponential
            //Display the result
            Executer run = new Executer();
            run.run();
            Console.ReadLine();
        }
    }
}
