using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_and_perimeter_of_rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length: ");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter width: ");
            int width = int.Parse(Console.ReadLine());

            int area = length * width;
            int perimeter = (2 * length) + (2 * width);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimetet: " + perimeter);
        }
    }
}
