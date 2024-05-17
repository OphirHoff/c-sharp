using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4
{
    class Perfume
    {
        private string name;
        private string brand;
        private Node<Smell> smells;

        public Perfume(string name, string brand, Node<Smell> smells)
        {
            this.name = name;
            this.brand = brand;
            this.smells = smells;
        }

        public Node<Smell> GetSmells()
        {
            return this.smells;
        }

        public bool IsSmells100Precent()
        {
            double sum = 0;
            Node<Smell> pos = this.smells;

            while (pos != null)
                sum += pos.GetValue().GetPrecentage();

            return sum == 100;
        }

        public int HowManySmells()
        {
            return NodeUtils.CountList(this.smells);
        }

        public void PrintSmells()
        {
            Node<Smell> pos = this.smells;

            while(pos != null)
            {
                Console.Write(pos.GetValue() + "-->");
            }
        }
    }
}
