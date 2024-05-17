using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4
{
    class CoefficientPower
    {
        private int coefficient;
        private int power;

        public CoefficientPower(int coefficient, int power)
        {
            this.coefficient = coefficient;
            this.power = power;
        }

        public int GetCoefficient()
        {
            return this.coefficient;
        }

        public int GetPower()
        {
            return this.power;
        }

        //public int Coefficient
        //{
        //    get => Coefficient;
        //    set => Coefficient = value;
        //}
        //public int Power
        //{
        //    get => Power;
        //    set => Power = value;
        //}
    }
}
