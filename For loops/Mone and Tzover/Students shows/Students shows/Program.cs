using System;

namespace Students_shows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Counters
            int three_shows = 0;
            int one_show = 0;

            // Repeat 2000 times
            for (int i = 1; i <= 3; i++)
            {
                // Get what shows the student want to buy tickets for
                Console.WriteLine("Do you want to purchase a ticket for show A? (0 or 1)");
                int show1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Do you want to purchase a ticket for show B? (0 or 1)");
                int show2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Do you want to purchase a ticket for show C? (0 or 1)");
                int show3 = int.Parse(Console.ReadLine());

                // Check if student wants to purchase all three or just one
                if (show1 == 1 && show2 == 1 && show3 == 1)
                {
                    three_shows++;
                }
                else if ((show1 == 1 && show2 == 0 && show3 == 0) || (show1 == 0 && show2 == 1 && show3 == 0) || (show1 == 0 && show2 == 0 && show3 == 1))
                {
                    one_show++;
                }
            }
            Console.WriteLine($"{three_shows} students purchesed tickets for all three shows");
            Console.WriteLine($"{one_show} students purchesed tickets for one show");
        }
    }
}
