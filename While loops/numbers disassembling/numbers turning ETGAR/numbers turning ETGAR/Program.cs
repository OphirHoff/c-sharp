using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers_turning_ETGAR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); // Call random

            for (int i = 1; i <= 10; i++)
            {
                int num = rnd.Next(45, 140); // get number

                Console.WriteLine(num);

                int saveNum = num; // save number
                int units = num % 10; // save units

                int digits = 0; // digits counter
                while (num > 0)
                {
                    digits++;
                    num /= 10;
                }

                // Multiply units by 10 digits-1 times
                for (int x = 1; x < digits; x++)
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
}
