using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seconds_to_hours__minutes__seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of seconds: ");
            // Get number of seconds from user
            int sec = int.Parse(Console.ReadLine());

            // Convert seconds to hours
            int hrs = sec / 3600;

            // Convert to minutes
            int minutes = (sec - (hrs * 3600)) / 60;

            // Convert to seconds left
            int seconds = (sec - (hrs * 3600)) % 60;



            Console.WriteLine($"{hrs / 10}{hrs % 10}:{minutes / 10}{minutes % 10}:{seconds / 10}{seconds % 10}");
        }
    }
}
