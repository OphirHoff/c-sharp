using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shilush
{
    internal class Program
    {
        public static bool Shilush (int num)
        {
            double sum = 0; // sum of units cubed
            int saveNum = num; // gibui

            // peiruk number
            while (num != 0)
            {
                double units = num % 10; // get units
                sum += Math.Pow(units, 3); //cube units
                num = num / 10; //get rid of units
            }

            // check if sum of units cubed == number
            if (saveNum == sum)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            // go over all positive integers
            for (int i = 1; i < int.MaxValue; i++)
            {
                bool shilush = Shilush (i); //shilush of i
                if (shilush == true) // check if true
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
