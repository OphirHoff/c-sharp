using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxis_exersice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many people are waiting for a taxi? ");
            // get number of people waiting for a taxi from user
            int waiting = int.Parse(Console.ReadLine());

            // number of people that remained without a taxi
            int remain = waiting % 6;
            
            // number of taxis left
            int taxis_num = waiting / 6;

            Console.WriteLine($"{taxis_num} taxis left, {remain} still waiting");
        }
    }
}
