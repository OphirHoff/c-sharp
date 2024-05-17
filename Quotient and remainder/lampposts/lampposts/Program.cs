using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lampposts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much money was alocted for replacing the lampposts? ");
            // get amount of many alocated from user
            int money = int.Parse(Console.ReadLine());

            Console.WriteLine("How much does one lamppost costs? ");
            // get the cost of one lamppost from user
            int lamppost_price = int.Parse(Console.ReadLine());

            // calculate number of lampposts
            int lampposts_num = money / lamppost_price;

            // calculate money remained after expenses
            int remained_money = money % lamppost_price;

            Console.WriteLine($"Replace {lampposts_num} lampposts. {remained_money}$ will remain.");
        }
    }
}
