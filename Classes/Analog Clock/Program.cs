using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Analog_Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            AnalogClock clock1 = new AnalogClock();
            clock1.SetTime(12, 0, 0);

            AnalogClock clock_NewYork = new AnalogClock();
            clock_NewYork.SetTime(5, 0, 0);

            AnalogClock clock_London = new AnalogClock();
            clock_London.SetTime(10, 0, 0);

            AnalogClock clock_Spain = new AnalogClock();
            clock_Spain.SetTime(11, 0, 0);

            AnalogClock clock_Tokyo = new AnalogClock();
            clock_Tokyo.SetTime(19, 0, 0);
            Console.WriteLine(clock_Tokyo);

            Console.Clear();

            bool cont = true;
            while (cont == true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo k = Console.ReadKey();
                    if (k.Key == ConsoleKey.Escape)
                    {
                        cont= false;
                    }
                }

                Console.WriteLine("Local: " + clock1);
                clock1.AddSecond();
                Console.WriteLine("New York: " + clock_NewYork);
                clock_NewYork.AddSecond();
                Console.WriteLine("London: " + clock_London);
                clock_London.AddSecond();
                Console.WriteLine("Spain: " + clock_Spain);
                clock_Spain.AddSecond();
                Console.WriteLine("Tokyo: " + clock_Tokyo);
                clock_Tokyo.AddSecond();

                Console.SetCursorPosition(0, 0);

                Thread.Sleep(1000);
            }
        }
    }
}
