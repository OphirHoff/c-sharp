using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_of_tomorrow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter day: ");
            // get day from user
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter month: ");
            // get month from user
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter year: ");
            // get year from user
            int year = int.Parse(Console.ReadLine());

            // check if it's NOT end of month
            if (day < 30)
            {
                // check if it's end of february
                if (day == 28 && month == 2)
                {
                    month += 1;
                    day = 1;
                }
                else
                    day += 1;
            }
                // check if it's end of a 30 days month 
            if (day == 30)
            {
                if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    month += 1;
                    day = 1;
                }
                else
                    day += 1;
            }

            // check if its end of a 31 days month
            if (day == 31)
            {
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10)
                {
                    month += 1;
                    day = 1;
                }
                else
                {
                    day = 1;
                    month = 1;
                    year += 1;
                }
                
            }

                Console.WriteLine($"{day}/{month}/{year}");
        }
    }
}
