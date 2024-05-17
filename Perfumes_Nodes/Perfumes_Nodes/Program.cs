using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;

namespace Perfumes_Nodes
{
    internal class Program
    {
        public static void Test_CommonSmells()
        {
            Node<Smell> smells1 = new Node<Smell>(new Smell("Rose", 4, 30));
            smells1.SetNext(new Node<Smell>(new Smell("fruits", 6, 60)));
            smells1.GetNext().SetNext(new Node<Smell>(new Smell("woods", 8, 10)));

            Perfume p1 = new Perfume("Dior Homme", "Dior", smells1);

            Node<Smell> smells2 = new Node<Smell>(new Smell("fruits", 6, 30));
            smells2.SetNext(new Node<Smell>(new Smell("berry", 6, 60)));
            smells2.GetNext().SetNext(new Node<Smell>(new Smell("woods", 8, 10)));

            Perfume p2 = new Perfume("Paco Rabanne", "XS", smells2);

            Node<Smell> commonSmells = CommonSmells(p1, p2);
            Console.Write("result : ");

            Node<Smell> pos = commonSmells;

            while (pos != null)
            {
                Console.Write(" " + pos.GetValue() + "--> ");
                pos = pos.GetNext();
            }
        }

        public static bool IsSmellInList(Node<Smell> smells, Smell smell)
        {
            bool found = false;

            while (!found && smells != null)
            {
                found = smells.GetValue().GetName() == smell.GetName() && smells.GetValue().GetStrength() == smell.GetStrength();
                smells = smells.GetNext();
            }

            return found;
        }

        public static Node<Smell> CommonSmells(Perfume p1, Perfume p2)
        {
            Node<Smell> smells1 = p1.GetSmells();
            Node<Smell> smells2 = p2.GetSmells();

            Node<Smell> head = null;
            Node<Smell> pos = null;

            while (smells1 != null)
            {
                if (IsSmellInList(smells2, smells1.GetValue()))
                {
                    if (head == null)
                    {
                        head = new Node<Smell>(smells1.GetValue());
                        pos = head;
                    }

                    else
                    {
                        pos.SetNext(new Node<Smell>(smells1.GetValue()));
                        pos = pos.GetNext();
                    }

                }

                smells1 = smells1.GetNext();
            }

            return head;
        }


        static void Main(string[] args)
        {
            Test_CommonSmells();
        }
    }
}
