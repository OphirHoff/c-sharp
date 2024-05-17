using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pacman
{
    class Program
    {
        public static void CreateSquare(int x, int y)
        {
            Console.CursorVisible = false;

            Console.SetCursorPosition(x, y);
            Console.Write("---------");
            Console.SetCursorPosition(x, y + 4);
            Console.Write("---------");

            Console.SetCursorPosition(x, y);
            Console.Write("|");
            Console.SetCursorPosition(x, y+1);
            Console.Write("|");
            Console.SetCursorPosition(x, y+2);
            Console.Write("|");
            Console.SetCursorPosition(x, y+3);
            Console.Write("|");
            Console.SetCursorPosition(x, y + 4);
            Console.Write("|");

            Console.SetCursorPosition(x+8, y);
            Console.Write("|");
            Console.SetCursorPosition(x+8, y + 1);
            Console.Write("|");
            Console.SetCursorPosition(x + 8, y + 2);
            Console.Write("|");
            Console.SetCursorPosition(x + 8, y + 3);
            Console.Write("|");
            Console.SetCursorPosition(x + 8, y + 4);
            Console.Write("|");
        }

        static void Main(string[] args)
        {

            //borders
            int borderWidth = 25;

            Console.SetCursorPosition(borderWidth, 0);
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("—");
                borderWidth++;
                Console.SetCursorPosition(borderWidth, 0);
            }

            borderWidth = 25;
            Console.SetCursorPosition(borderWidth, 25);
            for (int i = 1; i <= 50; i++)
            {
                Console.Write("—");
                borderWidth++;
                Console.SetCursorPosition(borderWidth, 25);
            }

            int borderHeight = 0;
            Console.SetCursorPosition(25, borderHeight);
            for (int i = 1; i <= 26; i++)
            {
                Console.Write("|");
                borderHeight++;
                Console.SetCursorPosition(25, borderHeight);
            }

            borderHeight = 0;
            Console.SetCursorPosition(75, borderHeight);
            for (int i = 1; i <= 26; i++)
            {
                Console.Write("|");
                borderHeight++;
                Console.SetCursorPosition(75, borderHeight);
            }

            // ghosts starting block

            Console.SetCursorPosition(45, 13);
            Console.Write("——————————-");

            Console.SetCursorPosition(45,12);
            Console.Write("|");
            Console.SetCursorPosition(45, 13);
            Console.Write("|");

            Console.SetCursorPosition(55, 12);
            Console.Write("|");
            Console.SetCursorPosition(55, 13);
            Console.Write("|");

            // inner walls
            CreateSquare(29, 2);
            CreateSquare(63, 2);
            CreateSquare(29, 19);
            CreateSquare(63, 19);

            // create pacman
            Pacman pacman = new Pacman();
            pacman.Draw();
            bool cont = true;

            while (cont)
            {
                if (Console.KeyAvailable)
                {
                    pacman.Undraw();
                    ConsoleKeyInfo k = Console.ReadKey();
                    if (k.Key == ConsoleKey.UpArrow)
                        pacman.MoveUp();
                    else if (k.Key == ConsoleKey.DownArrow)
                        pacman.MoveDown();
                    else if (k.Key == ConsoleKey.LeftArrow)
                        pacman.MoveLeft();
                    else if (k.Key == ConsoleKey.RightArrow)
                        pacman.MoveRight();
                    else if (k.Key == ConsoleKey.Escape)
                        cont = false;
                }
                Thread.Sleep(50);
            }
        }
    }
}
