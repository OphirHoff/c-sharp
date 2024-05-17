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
            Circle circle5 = new Circle(10, ConsoleColor.Magenta);
            circle5.Print();
            Circle circle6 = new Circle(3, ConsoleColor.Green);
            circle6.Print();

            circle5.SetColor(ConsoleColor.DarkRed);
            circle5.Print();

            circle6.SetRadius(4.5);
            circle6.Print();

            Console.WriteLine("enter circle 7 radius");
            int radius7 = int.Parse(Console.ReadLine());
            Circle circle7 = new Circle(radius7, ConsoleColor.Yellow);
            circle7.Print();

            int radius8 = rnd.Next(1, 11);
            Circle circle8 = new Circle(radius8, ConsoleColor.Black);
            circle8.Print();

            circle6.Radius_add();
            circle6.Print();
            circle7.Radius_add();
            circle7.Print();

            circle6.Radius_sub();
            circle6.Print();
            circle7.Radius_sub();
            circle7.Print();

            Console.WriteLine(circle6.GetArea());

            Console.WriteLine(circle7.GetPerimeter());

            Circle circle9 = new Circle(ConsoleColor.Red);
            circle9.Print();

            Circle circle10 = new Circle(ConsoleColor.Magenta);
            circle10.Print();

            Circle circle11 = new Circle(5, ConsoleColor.Blue);
            circle11.Print();

            Circle circle12 = new Circle(5, ConsoleColor.Yellow, true, true);
            circle12.Print();

            Circle circle13 = new Circle(15, ConsoleColor.DarkRed, true, false);
            circle13.Print();

            circle13.Draw();
        }
    }
}
