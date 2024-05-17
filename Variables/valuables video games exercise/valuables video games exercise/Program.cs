using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valuables_video_games_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Video Game 1 price: ");
            double game1_price = double.Parse(Console.ReadLine());

            Console.WriteLine("Video Game 2 price: ");
            double game2_price = double.Parse(Console.ReadLine());

            Console.WriteLine("Video Game 3 price: ");
            double game3_price = double.Parse(Console.ReadLine());

            double total = game1_price + game2_price + game3_price;

            Console.WriteLine("Total: " + total);

        }
    }
}
