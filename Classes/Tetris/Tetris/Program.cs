using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int x = 0;
            int y = 0;

            Console.SetCursorPosition(x + 2, y);
            Console.Write("████");
            Console.SetCursorPosition(x, y+1);
            Console.Write("████");

            Thread.Sleep(1000);

            Console.SetCursorPosition(x + 2, y);
            Console.Write("    ");
            Console.SetCursorPosition(x, y + 1);
            Console.Write("    ");*/

            Console.CursorVisible = false;

            bool end = false;

            Random rnd = new Random();

            
            


            int leftBorderY = 0;
            Console.SetCursorPosition(35, leftBorderY);
            for(int i = 1; i <= 27; i++)
            {
                Console.Write("|");
                leftBorderY++;
                Console.SetCursorPosition(35, leftBorderY);
            }

            int rightBorderY = 0;
            Console.SetCursorPosition(80, rightBorderY);
            for (int i = 1; i <= 27; i++)
            {
                Console.Write("|");
                rightBorderY++;
                Console.SetCursorPosition(80, rightBorderY);
            }

            int bottomBorderX = 35;
            Console.SetCursorPosition(bottomBorderX, 27);
            for(int i = 1; i <= 45; i++)
            {
                Console.Write("——");
                bottomBorderX++;
                Console.SetCursorPosition(bottomBorderX, 27);
            }

            int newShapeNum = rnd.Next(1, 4);
            Shape shape = new Shape(2);

            while (!end)
            {
                shape.MoveDown();
                
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo k = Console.ReadKey();
                    
                    if (k.Key == ConsoleKey.Spacebar)
                        shape.Turn();
    
                }
                Thread.Sleep(500);
            }
            


        }
    }
}
