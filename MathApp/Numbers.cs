using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    class Numbers
    { 
        public List<string> getNumberString()
        {
            string numberInput;
            List<string> newNumbers = new List<string>();
            Console.WriteLine("Please enter the number followed by the operator and next number you would like calculated, seperated by a spaces. Sequential operations can be used. \n\rEx. 5 + 4 * 2 / 3 ^ 2");
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