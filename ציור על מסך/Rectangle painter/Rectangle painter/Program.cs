using System;
using System.Threading;

namespace Rectangle_painter
{
    internal class Program
    {
        public static void RecDraw(int x, int y, int height, int width, ConsoleColor color)
        {

            Console.ForegroundColor = color; //change font color

            char ch = '█';

            Console.SetCursorPosition(x, y); // adjust cursor position

            // print width rectangles height times
            for (int h = 1; h <= height; h++)
            {
                for (int w = 1; w <= width; w++)
                {
                    Console.Write(ch);
                }
                y++; // lower cursor by 1 line
                Console.SetCursorPosition(x, y);
            }
        }

        public static void RecDel(int x, int y, int height, int width)
        {
            Console.ForegroundColor = ConsoleColor.Black; //change font color to black

            char ch = '█';

            Console.SetCursorPosition(x, y); //adjust cursor position

            for (int h = 1; h <= height; h++)
            {
                for (int w = 1; w <= width; w++)
                {
                    Console.Write(ch);
                }
                y++; // lower cursor by 1 line
                Console.SetCursorPosition(x, y);
            }
        }

        public static void RecMov(int x, int y, int height, int width, ConsoleColor color)
        {
            bool reached_border = false;

            while (reached_border == false)
            {
                RecDraw(x, y, height, width, color);

                Thread.Sleep(10);

                RecDel(x, y, height, width);

                if (x + width + 1 > 79)
                {
                    reached_border = true;
                }

                else
                {
                    x += 1;
                    RecDraw(x, y, height, width, color);
                }
            }
        }

        public static void RecArrowMov(int x, int y, int height, int width, ConsoleColor color)
        {
            bool end = false;

            while (!end)
            {
                if (Console.KeyAvailable)
                {
                    RecDel(x, y, height, width);

                    ConsoleKeyInfo k = Console.ReadKey();

                    if (k.Key == ConsoleKey.UpArrow)
                        y--;
                    else if (k.Key == ConsoleKey.DownArrow)
                        y++;
                    else if (k.Key == ConsoleKey.LeftArrow)
                        x--;
                    else if (k.Key == ConsoleKey.RightArrow)
                        x++;
                    else if (k.Key == ConsoleKey.Escape)
                        end = true;
                    RecDraw(x, y, height, width, color);
                }
                Thread.Sleep(50);
            }
        }

        static void Main(string[] args)
        {

            int x = 1;
            int y = 1;
            int height = 20;
            int width = 20;
            ConsoleColor color = ConsoleColor.Red;

            //RecDraw(x, y, height, width, color);

            //Console.ReadKey();

            //RecDel(x, y, height, width);

            //Console.ReadKey();

            //RecMov(x, y, height, width, color);

            //Console.ReadKey();

            RecArrowMov(x, y, height, width, color);
        }
    }
}
