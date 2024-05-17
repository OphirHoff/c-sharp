using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Placed_Digits
{
    internal class Program
    {
        public static int OddPlacedDigits (int num)
        {
            int newNum = 0;
            int powerOfTen = 0;

            while (num != 0)
            {
                newNum += (num % 10) * (int)Math.Pow(10, powerOfTen);
                powerOfTen++;
                num /= 100;
            }

            return newNum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(OddPlacedDigits(num));
        }
    }
}
