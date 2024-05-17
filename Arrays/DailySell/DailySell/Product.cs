using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailySell
{
    enum ProductTypes { Sandwhich, Drink };
    class Product
    {
        private ProductTypes Ptype;
        private double cost;
        private double price;
        private string name;
        private double weight;
        private double caloricValue;

        public Product(ProductTypes Ptype, string name, int weight, int cost, double caloricValue)
        {
            this.Ptype = Ptype;
            this.name = name;
            this.weight = weight;
            this.cost = cost;
            this.price = cost + (30 / 100) * cost;
            this.caloricValue = caloricValue;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public ProductTypes GetPtye()
        {
            return this.Ptype;
        }
        
        public double GetPrice()
        {
            return this.price;
        }

        public double GetCost()
        {
            return this.cost;
        }

        public double GetCaloricValue()
        {
            return this.caloricValue * 300;
        }

        public void SetSellPrice(double price)
        {
            this.price = price;
        }

        public override string ToString()
        {
            return this.Ptype + ", " + this.name + ", " + this.weight + ", " + this.cost + ", " + this.price;
        }
    }
}
