using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    { 
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Circle circle1 = new Circle(7.5, ConsoleColor.Blue); // Creates small blue  Circle
            circle1.Print(); // Prints Circle1
            Circle circle2 = new Circle(80, ConsoleColor.Red); // Creates big red Circle
            circle2.Print(); // Prints Circle2

            Circle circle3 = new Circle(rnd.Next(1, 11), ConsoleColor.Green);
            circle3.Print();
            double radius = circle3.GetRadius();// get the radius of circle 3
            Circle circle4 = new Circle(radius + 1, ConsoleColor.DarkRed);
            circle4.Print();
        }
    }
}
