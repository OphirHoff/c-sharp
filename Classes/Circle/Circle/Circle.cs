using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        Random rnd = new Random();

        private double radius;
        private ConsoleColor color;
        private bool isFull;
        private bool isBenGvirSupporter;

        // constructor בנאי
        public Circle(double r, ConsoleColor c)
        {
            this.radius = r;
            this.color = c;
        }

        // בנאי עם קביעה כמלא
        public Circle(double r, ConsoleColor c, bool isItFull)
        {
            this.radius = r;
            this.color = c;
            this.isFull = isItFull;
        }

        // בנאי - עם תכונה האם תומך בבן גביר
        public Circle(double r, ConsoleColor c,bool isItFull, bool SupportsBenGvir)
        {
            this.radius = r;
            this.color = c;
            this.isFull = isItFull;
            this.isBenGvirSupporter = SupportsBenGvir;
        }

        // פעולה קובעת ממלא עיגול
        public void Fill()
        {
            isFull = true;
        }

        // פעולה קובעת עיגול ריק
        public void Empty()
        {
            isFull = false;
        }

        // פעולה מאחזרת - האם עיגול מלא
        public bool IsFull()
        {
            return isFull;
        }

        public void Print()
        {
		    Console.Write("I am a " );
			Console.ForegroundColor = color;
			Console.Write(color);
			Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Circle with radius " + radius);
            Console.WriteLine("Is full = " + isFull);
            Console.WriteLine("Circle is an Itamar Ban Gvir supporter: " + isBenGvirSupporter);
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

        // פעולה מגדילה רדיוס
        public void Radius_add()
        {
            radius++;
        }

        // פעולה מקטינה רדיוס
        public void Radius_sub()
        {
            radius--;
        }

        // פעולה מאחזרת שטח
        public double GetArea()
        {
            return (Math.PI * radius * radius);
        }

        // פעולה מאחזרת היקף
        public double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        // פעולה מאחזרת רדיוס רנדומלי
        public Circle(ConsoleColor c)
        {
            radius = rnd.Next(1,11);
            color = c;
        }

        // פעולה קובעת האם העיגול תומך בבן גביר
        public void SetBenGvirSupporter(bool b)
        {
            isBenGvirSupporter = b;
        }

        // פעולה מאחזרת האם העיגול תומך בבן גביר
        public bool GetOpinionAboutBenGvir()
        {
            return isBenGvirSupporter;
        }

        // פעולת אתגר - ציור עיגול
        public void Draw()
        {
            Console.SetBufferSize(201, 201);
            Console.CursorVisible = false;
            Console.Clear();

            for (double angle = 0; angle < 2 * Math.PI; angle += Math.PI / 180)
            {
                int x = (int)Math.Round(this.radius * Math.Cos(angle) + this.radius);
                int y = (int)(0.5 * Math.Round(this.radius * Math.Sin(angle) + this.radius));
                Console.SetCursorPosition(x, y);
                for (int i = 0; i < Math.Abs(this.radius * Math.Sin(angle)); i++)
                {
                    Console.SetCursorPosition((int)x, (int)(y - (i * Math.Sign(Math.Sin(angle)))));
                    Console.Write("██");
                }
                Console.WriteLine("██");
            }

            Console.SetCursorPosition(0, (int)this.radius + 1);
        }

    }
}