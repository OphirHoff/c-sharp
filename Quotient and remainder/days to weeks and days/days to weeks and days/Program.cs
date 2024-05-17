using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace days_to_weeks_and_days
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of days: ");
            // get number of days from user
            int days_input = int.Parse(Console.ReadLine());

            // convert days to weeks
            int weeks = days_input / 7;

            // calculate remained days
            int remained_days = days_input - (weeks * 7);

            Console.WriteLine($"Weeks: {weeks}, days: {remained_days}.");

        }
    }
}
