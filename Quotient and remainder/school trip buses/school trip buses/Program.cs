using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace school_trip_buses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students are going on the trip? ");
            // get number of students from user
            int students_num = int.Parse(Console.ReadLine());

            // number of buses required
            int buses_num = students_num / 46;

            Console.WriteLine($"{buses_num} buses are needed for the trip.");


        }
    }
}
