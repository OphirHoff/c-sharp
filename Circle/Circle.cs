using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        private double radius;
        private ConsoleColor color;

        // constructor בנאי
        public Circle(double r, ConsoleColor c)
        {
            radius = r;
            color = c;
        }
        
        public void Print()
        {
		    Console.Write("I am a " );
			Console.ForegroundColor = color;
			Console.Write(color);
			Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Circle with radius " + radius);
        }

        //   פעולה קובעת רדיוס
        public void SetRadius(double r)
        {
            radius = r;
        }

        // פעולה מאחזרת רדיוס
        public double GetRadius()
        {
            return radius;
        }

        //  פעולה קובעת צבע
        public void SetColor(ConsoleColor c)
        {
            color = c;
        }

        // פעולה מאחזרת צבע
        public ConsoleColor GetColor()
        {
            return color;
        }
    }
}
