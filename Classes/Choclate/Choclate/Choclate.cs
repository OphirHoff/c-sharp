using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choclate
{
    class Choclate
    {
        private string brand;
        private enum Type { Milk, Dark, White}; //milk=0, dark=1, white=2
        private Type type;
        private int cocoaPrecantage;
        private int expiryDate; //DDMMYY e.g.: 251222
        private int cubes = 4;
        private int CubesEaten;
        private bool kosher;

        public Choclate (string brand,int type, int cocoaPrecantage, int expiryDate, bool kosher)
        {
            this.brand = brand;
            this.type = (Type)type;
            this.cocoaPrecantage = cocoaPrecantage;
            this.expiryDate = expiryDate;
            this.kosher = kosher;
        }

        public void Eat(int howManyCubes)
        {
            if (howManyCubes < cubes && howManyCubes > 0)
            {
                this.cubes -= howManyCubes;
                CubesEaten+=howManyCubes;
            }
        }

        public void EatAll()
        {
            this.cubes = 0;
        }

        public int HowManyCubesLeft()
        {
            return this.cubes;
        }
        
        public int HowManyCubesEaten()
        {
            return CubesEaten;
        }

        public void Draw()
        {
            for (int i = 1; i <= cubes; i++)
            {
                Console.Write("█");
            }
        }

        public void GetValue()
        {
            Console.WriteLine($"Cubes: {this.cubes}, Cocoa precentage: {cocoaPrecantage}.");
        }

        public bool IsKosher()
        {
            return kosher;
        }

        public int GetExpiryDate()
        {
            return expiryDate;
        }
    }
}
