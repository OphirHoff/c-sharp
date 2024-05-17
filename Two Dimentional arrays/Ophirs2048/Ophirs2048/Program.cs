using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophirs2048
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            My2048 arr = new My2048(4);
            arr.Draw();
            
            bool cont = true;
            while (cont)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo k = Console.ReadKey();

                    if (k.Key == ConsoleKey.LeftArrow)
                    {
                        cont = arr.Move2048(My2048.Direction.Left);
                        arr.Draw();
                    }
                    else if (k.Key == ConsoleKey.RightArrow)
                    {
                        cont = arr.Move2048(My2048.Direction.Right);
                        arr.Draw();
                    }

                    else if (k.Key == ConsoleKey.UpArrow)
                    {
                        cont = arr.Move2048(My2048.Direction.Up);
                        arr.Draw();
                    }

                    else if (k.Key == ConsoleKey.DownArrow)
                    {
                        cont = arr.Move2048(My2048.Direction.Down);
                        arr.Draw();
                    }
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Game Over");
        }


    }
}
