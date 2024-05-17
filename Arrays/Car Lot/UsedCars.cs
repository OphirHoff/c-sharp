using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Lot
{
    class UsedCars
    {
        private const int MaxCars = 1000;
        private Car[] usedCars;
        private int empty;
        public UsedCars ()
        {
            this.usedCars = new Car[MaxCars];
        }

        public void AddCar(Car c)
        {
            if (empty < 1000)
            {
                usedCars[empty] = c;
                empty++;
            }
        }

        public void AddCar(string num, string model, int year)
        {
            Car car = new Car(num, model, year);
            AddCar(car);
        }

        public void PrintAllCarsProducedBefor(int year)
        {
            for (int i = 0; i < empty; i++)
            {
                if (usedCars[i].GetYear() < year)
                {
                    Console.Write(usedCars[i]);
                    Console.WriteLine();
                }
            }
        }

        public int HowMuch(string model)
        {
            int cnt = 0;
            for (int i = 0; i < empty; i++)
            {
                if (usedCars[i].GetModel() == model)
                    cnt++;
            }
            return cnt;
        }
    }
}
