using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace right_angle_triangle_maker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a sign: ");
            char tav = char.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine(tav);
            Console.WriteLine(tav + "" + tav);
            Console.WriteLine(tav + "" + tav + tav);
            Console.WriteLine(tav + "" + tav + tav + tav);
        }
    }
}
