using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Lot
{
    class Car
    {
        private string num;
        private string model;
        private int year;

        public Car(string num, string model, int year)
        {
            this.num = num;
            this.model = model;
            this.year = year;
        }

        public string GetModel()
        {
            return this.model;
        }

        public int GetYear()
        {
            return this.year;
        }

        public bool Older(Car OtherCar)
        {
            return this.year < OtherCar.year;
        }

        public bool Equals(Car OtherCar)
        {
            return this.year == OtherCar.year;
        }

        public override string ToString()
        {
            string s = "Num: " + this.num + ", Model: " + this.model + ", Year " + this.year;
            return s;
        }
    }
}
