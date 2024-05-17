using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dani_s_money_and_savings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much money does Dani have? ");
            double money = double.Parse(Console.ReadLine());

            double savings = money/3;
            money = money - savings;

            money = money - (0.75 * money);

            Console.WriteLine("Savings: " + savings);
            Console.WriteLine("Dani has " + money + " left");
        }
    }
}
