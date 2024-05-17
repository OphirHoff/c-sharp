using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailySell
{
    internal class Program
    {
        public static void AddXNIS(Product[] a, int length, int x)
        {
            for (int i = 0; i < length; i++)
            {
                a[i].SetPrice(a[i].GetPrice()+3);
            }
        }

        static void Main(string[] args)
        {

            DailySell ds = new DailySell(new DateTime(2021, 12, 28));

            ds.BuyAtMorning(10, 5, 20, 8);

            Console.WriteLine(ds);
            Console.WriteLine("Current Profit:" + ds.GetCurrentProfit());

            ds.SellDrink();
            ds.SellDrink();
            ds.SellDrink();
            ds.SellDrink();
            ds.SellSandwich();
            ds.SellSandwich();

            Console.WriteLine(ds);
            Console.WriteLine("Current Profit:" + ds.GetCurrentProfit());

            ds.GetSandwich(0).SetSellPrice(12);

            ds.ShowAll();

            Console.ReadLine();

            AddXNIS(ds.GetDrinks(), ds.GetTotalDrinks(), 3);

            ds.SellDrink();
            Console.WriteLine(ds);
            Console.WriteLine("Current Profit:" + ds.GetCurrentProfit());
            ds.ShowAll();

        }
    }
}
