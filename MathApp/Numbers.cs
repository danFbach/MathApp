using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class Numbers
    {
        public int getFirstNumber()
        {
            int number1;
            Console.WriteLine("Please enter your first number.");
            number1 = int.Parse(Console.ReadLine());
            return number1;
        }
        public int getSecondNumber()
        {
            int number2;
            Console.WriteLine("Please enter your first number.");
            number2 = int.Parse(Console.ReadLine());
            return number2;
        }
    }
}
