using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities_after_school
{
    class Program
    {
        static void Main(string[] args)
        {
            // Counters
            int three_activities = 0;
            int two_activities = 0;
            int moreThan_three = 0;
            int more_toursThan_parties = 0;

            int n = 100;

            // Repeat n times
            for (int i = 1; i <= n; i++)
            {
                // Get number of tours the student went on
                Console.WriteLine("Enter number of tours: ");
                int tours = int.Parse(Console.ReadLine());

                // Get number of parties
                Console.WriteLine("Enter number of parties: ");
                int parties = int.Parse(Console.ReadLine());

                // Get number of movies watched
                Console.WriteLine("Enter number of movies: ");
                int movies = int.Parse(Console.ReadLine());

                // Check first condition
                if (tours >= 1 && parties >= 1 && movies >= 1)
                {
                    three_activities++;
                }

                // Check second condition
                if ((tours >= 1 && parties >= 1 && movies == 0) || (tours >= 1 && parties >= 0 && movies == 1) || (tours >= 0 && parties >= 1 && movies == 1))
                {
                    two_activities++;
                }

                // Check third condition
                if (tours > 3 || parties > 3 || movies > 3)
                {
                    moreThan_three++;
                }

                // Check fourth condition
                if (tours > parties)
                {
                    more_toursThan_parties++;
                }

            }
            Console.WriteLine("Had all three activities: " + three_activities);
            Console.WriteLine("Had exactly two activities: " + two_activities);
            Console.WriteLine("Had more than three times an activity: " + moreThan_three);
            Console.WriteLine("Had more tours than parties: " + more_toursThan_parties);

        }
    }
}
