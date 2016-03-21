using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class Numbers
    {
        public double getFirstNumber()
        {
            double number1;
            Console.WriteLine("Please enter your first number.");
            number1 = double.Parse(Console.ReadLine());
            return number1;
        }
        public double getSecondNumber()
        {
            double number2;
            Console.WriteLine("Please enter your first number.");
            number2 = double.Parse(Console.ReadLine());
            return number2;
        }
    }
}
