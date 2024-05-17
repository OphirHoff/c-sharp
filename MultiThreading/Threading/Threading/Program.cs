using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(() => CountDown());
            Thread thread2 = new Thread(() => CountUp());
            thread1.Start();
            thread2.Start();
        }

        public static void CountDown()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("CountDown: " + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Finished.");
        }
        

        public static void CountUp()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("CountUp: " + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Finished.");
        }
    }
}
