using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace number_of_boys_and_girls_in_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of boys: ");
            int boys = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of girls: ");
            int girls = int.Parse(Console.ReadLine());

            int total = boys + girls;
            int difference = boys - girls;

            Console.WriteLine("Total:" + total);
            Console.WriteLine("Difference: " + difference);
                
        }
    }
}
