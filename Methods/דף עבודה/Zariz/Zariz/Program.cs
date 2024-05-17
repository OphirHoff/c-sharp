using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zariz
{
    internal class Program
    {
        public static bool Zariz (int num)
        {
            bool is_zariz = true;

            // Peiruk of the digits
            while (num > 10 && is_zariz)
            {
                int dig = num % 10; //current units
                int nextDig = (num / 10) % 10; // next digit (dozens)

                //check if units if bigger than dozens
                if(dig > nextDig)
                {
                    is_zariz = false;
                }
                num /= 10; //get rid of units
            }
            return is_zariz;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            // Zakif
            while(num != 999)
            {

                // check if number is Zariz using the method above
                bool zariz = Zariz(num);
                if(zariz == true)
                {
                    Console.WriteLine("This number is zariz");
                }
                else
                {
                    Console.WriteLine("This number is NOT zariz");
                }

                num = int.Parse(Console.ReadLine());// get a new number
            }
        }
    }
}
