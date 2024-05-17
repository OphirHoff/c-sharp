using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Unit4
{
    class Smell
    {
        private string name;
        private int strength;
        private double precentage;

        public Smell(string name, int strength, double precentage)
        {
            this.name = name;
            this.strength = strength;
            this.precentage = precentage;
        }

        public string GetName()
        {
            return this.name;
        }
            
        public int GetStrength()
        {
            return this.strength;
        }

        public double GetPrecentage()
        {
            return this.precentage;
        }

        public bool CompareTo(Smell s)
        {
            return this.GetName() == s.GetName() && this.GetStrength() == s.GetStrength();
        }

        public override string ToString()
        {
            return this.name + " | strength=" + this.strength;
        }
    }
}
