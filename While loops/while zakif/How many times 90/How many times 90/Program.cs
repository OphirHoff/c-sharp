using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace How_many_times_90
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            while (num != 10)
            {
                if (num == 90)
                {
                    count++;
                }

                Console.WriteLine("Enter a number");
                num = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("There was " + count + " times 90");
        }
    }
}
