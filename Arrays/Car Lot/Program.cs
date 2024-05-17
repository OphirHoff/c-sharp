using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            UsedCars uc = new UsedCars();
            uc.AddCar("90-123-56", "toyota", 2006);
            uc.AddCar("23-003-14", "ford", 2007);
            uc.AddCar("83-101-64", "mazda", 2008);
            Car c1 = new Car("13-501-36", "toyota", 2000);
            Car c2 = new Car("19-502-68", "mazda", 2009);
            uc.AddCar(c1);
            uc.PrintAllCarsProducedBefor(2008);
            Console.WriteLine(uc.HowMuch("toyota"));
        }
    }
}
