using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_digit_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a three-digit number: ");
            // get a three-digit number from user
            int num = int.Parse(Console.ReadLine());

            // hundreds of number
            int hundreds = num / 100;

            //units
            int units = num % 10;

            // dozens
            int dozends = (num - (hundreds * 100) - units) / 10;

            // check if the number meets all the conditions
            if ((hundreds + units) / 2 == dozends && hundreds * hundreds == Math.Sqrt(units))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");



        }
    }
}
