using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace digit_count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a digit");
            int digit = int.Parse(Console.ReadLine());

            while (num > 0)
            {
                if (num % 10 == digit)
                {
                    count++;
                }

                num /= 10;
            }
            Console.WriteLine(count);
        }
    }
}
