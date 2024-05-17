using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_turning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine()); // get number

            int saveNum = num; // save number
            int units = num % 10; // save units

            int digits = 0; // digits counter
            while (num > 0)
            {
                digits++;
                num /= 10;
            }

            // Multiply units by 10 digits-1 times
            for (int i = 1; i < digits; i++)
            {
                units *= 10;
            }

            // Get rid of units in saved number
            saveNum /= 10;
            // Add multiplied units to saved number
            saveNum += units;

            Console.WriteLine(saveNum);
        }
    }
}
