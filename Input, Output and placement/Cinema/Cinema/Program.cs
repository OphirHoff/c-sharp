using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tickets were sold? ");
            int tickets = int.Parse(Console.ReadLine());

            Console.WriteLine("Ticket price: ");
            int price = int.Parse(Console.ReadLine());

            int income = tickets * price;
            int empty_seats = 120 - tickets;
            int loss = empty_seats * price;

            Console.WriteLine("Income: " + income);
            Console.WriteLine("Loss: " + loss);
        }
    }
}
