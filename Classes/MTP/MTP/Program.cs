
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MTP
{
    internal class Program
    {
        public static void MoveMtp(MTP mtp)
        {
            mtp.UnDraw();
            mtp.RndMove();
            mtp.Draw();
        }

        public static void TouchMtp3(MTP mtp, MTP other)
        {
            if(mtp.Touch(other))
            {
                Console.Beep();
            }
        }

        
        static void Main(string[] args)
        {

            MTP mtp1 = new MTP(1 ,1, '#', ConsoleColor.Blue, ConsoleColor.Red, 1);
            MTP mtp2 = new MTP(10, 18, '$', ConsoleColor.Red, ConsoleColor.Blue, 2);
            MTP mtp3 = new MTP(44, 25, '@', ConsoleColor.Green, ConsoleColor.White, 1);
            MTP mtp4 = new MTP(44, 25, '*', ConsoleColor.Magenta, ConsoleColor.Yellow, 3);
            MTP mtp5 = new MTP(30, 35, '%', ConsoleColor.Cyan, ConsoleColor.DarkRed, 2);

            TouchMtp3(mtp3, mtp4);

            bool cont = true;

            while(cont)
            {
                mtp1.HitBoreders();
                MoveMtp(mtp1);
                mtp2.HitBoreders();
                MoveMtp(mtp2);
                mtp3.HitBoreders();
                if (Console.KeyAvailable)
                {
                    mtp3.UnDraw();
                    ConsoleKeyInfo k = Console.ReadKey();
                    if (k.Key == ConsoleKey.UpArrow)
                        mtp3.MoveUp();
                    else if (k.Key == ConsoleKey.DownArrow)
                        mtp3.MoveDown();
                    else if (k.Key == ConsoleKey.LeftArrow)
                        mtp3.MoveLeft();
                    else if (k.Key == ConsoleKey.RightArrow)
                        mtp3.MoveRight();
                    else if (k.Key == ConsoleKey.Escape)
                        cont = false;
                    mtp3.Draw();
                }
                Thread.Sleep(50);
            }
            
        }
    }
}
