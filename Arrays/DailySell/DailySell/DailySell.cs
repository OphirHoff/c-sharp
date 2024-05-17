using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailySell
{
    class DailySell
    {

        private DateTime saleDay;
        private Product[] sandwiches;
        private Product[] drinks;
        private int totalSandwiches;
        private int totalDrinks;
        private double totalCost;
        private double income;

        public DailySell (DateTime saleDay)
        {
            this.saleDay = saleDay;
            this.totalCost = 0;
        }

        public void BuyAtMorning(int totalSandwiches, int totalDrinks)
        {
            this.sandwiches = new Product[totalSandwiches];
            this.totalSandwiches = totalSandwiches;

            for (int i = 0; i<sandwiches.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sandwiches[i] = new Product(ProductTypes.Sandwhich, "Tuna", 200, 20, 30);
                    this.totalCost += sandwiches[i].GetCost();
                }
                else if (i % 3 == 0)
                {
                    sandwiches[i] = new Product(ProductTypes.Sandwhich, "Egg", 200, 25, 40);
                    this.totalCost += sandwiches[i].GetCost();
                }
                else
                {
                    sandwiches[i] = new Product(ProductTypes.Sandwhich, "Salmon", 200, 30, 50);
                    this.totalCost += sandwiches[i].GetCost();
                }
            }

            this.drinks = new Product[totalDrinks];
            this.totalDrinks = totalDrinks;

            for (int i = 0; i < drinks.Length; i++)
            {
                if (i % 2 == 0)
                    drinks[i] = new Product(ProductTypes.Drink, "Sprite", 300, 7, 10);
                else if (i % 3 == 0)
                    sandwiches[i] = new Product(ProductTypes.Drink, "Coke", 300, 10, 20);
                else
                    sandwiches[i] = new Product(ProductTypes.Drink, "Juice", 300, 8, 20);
            }
        }

        public bool SellSandwich()
        {
            if (sandwiches[totalSandwiches].GetCaloricValue() > 200)
            {
                Console.WriteLine("WARNING! THIS PRODUCT CALORIC VALUE IS HIGH!");
            }

            if (totalSandwiches > 0)
            {
                income += this.sandwiches[totalSandwiches - 1].GetPrice();
                totalSandwiches--;
                return true;
            }
            return false;
        }

        public bool SellDrink()
        {
            if (totalDrinks > 0)
            {
                income += this.drinks[totalDrinks - 1].GetPrice();
                totalDrinks--;
                return true;
            }
            return false;
        }

        public double GetCurrentProfit()
        {
            return totalCost - income;
        }

        public double GetCurrentWeight()
        {
            return (sandwiches.Length * 200) + (drinks.Length * 300);
        }

        public void ShowAll()
        {
            Console.WriteLine("Sandwhiches:");
            for (int i = 0; i < sandwiches.Length; i++)
            {
                Console.WriteLine(sandwiches[i]);
            }
            Console.WriteLine("Drinks:");
            for (int i = 0; i < drinks.Length; i++)
            {
                Console.WriteLine(drinks[i]);
            }
        }

        public Product GetSandwich(int i)
        {
            return sandwiches[i];
        }

        public Product[] GetDrinks()
        {
            return this.drinks;
        }

        public int GetTotalDrinks()
        {
            return totalDrinks;
        }

        public override string ToString()
        {
            string s = saleDay + ": " + "Sandwiches: " + totalSandwiches + ", Drinks: " + totalDrinks + ", Costs: " + totalCost + ", Income: " + this.income;
            return s;
        }




    }
}
