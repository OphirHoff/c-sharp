using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace surfing_the_web_price_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many minutes was Sharon surfing the internet for? ");
            int time = int.Parse(Console.ReadLine());

            int total = time / 30 * 2;

            Console.WriteLine("The total price is: " + total);
        }
    }
}
