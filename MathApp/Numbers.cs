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
            bool check = double.TryParse(Console.ReadLine(), out number1);
            if (!check) { Console.WriteLine("Invalid Entry"); return getFirstNumber(); }
            return number1;
        }
        public double getSecondNumber()
        {
            double number2;
            Console.WriteLine("Please enter your second number.");
            bool check = double.TryParse(Console.ReadLine(), out number2);
            if (!check) { Console.WriteLine("Invalid Entry"); return getSecondNumber(); }
            return number2;
        }
        public List<string> getNumberString()
        {
            string numberInput;
            List<string> newNumbers = new List<string>();
            Console.WriteLine("Please enter the numbers you would like calculated, seperated by a space.");
            numberInput = Console.ReadLine();
            string[] numbers = numberInput.Split(' ');

            for (int i = 0; i < numbers.Count(); i++)
            {
                string numberNew = (numbers[i]);
                newNumbers.Add(numberNew);
            }

            return newNumbers;
        }
    }
}
