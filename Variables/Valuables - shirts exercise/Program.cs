using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valuables___shirts_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter shirts price: ");
            double shirts_price = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of shirts: ");
           int shirts_num = int.Parse(Console.ReadLine());

            double total_price = shirts_price * shirts_num;

            Console.WriteLine("Your total price is: " + total_price);

        }
    }
}
