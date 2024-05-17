using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swimming_training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many trainings did Vered have this month? ");
            int training = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the legnth of the pool? ");
            double pool_length = double.Parse(Console.ReadLine());

            double total_meters = 10 * pool_length * training;
            double total_km = total_meters / 1000;

            Console.WriteLine("Vered swung " + total_meters + " meters this month");
            Console.WriteLine("equals to " + total_km + " km");
        }
    }
}
