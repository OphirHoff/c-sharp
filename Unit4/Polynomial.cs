using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Unit4
{
    class Polynomial
    {
        private static (Node<CoefficientPower> node, Node<CoefficientPower> lst) RemoveMax(Node<CoefficientPower> l)
        {
            int max_power = int.MinValue;
            Node<CoefficientPower> head = l;
            Node<CoefficientPower> max_node = null;
            Node<CoefficientPower> max_prev = null;
            Node<CoefficientPower> prev = null;

            while (l != null)
            {
                if (l.GetValue().GetPower() > max_power)
                {
                    max_node = l;
                    max_power = l.GetValue().GetPower();
                    max_prev = prev;
                }
                prev = l;
                l = l.GetNext();
            }

            if (max_prev == null)
                return (max_node, head.GetNext());

            if (max_prev != null)
                max_prev.SetNext(max_node.GetNext());

            return (max_node, head);
        }

        public static Node<CoefficientPower> SortPolynomial(Node<CoefficientPower> lst)
        {
            Node<CoefficientPower> copy = NodeUtils.CloneList(lst);
            Node<CoefficientPower> new_lst = null;
            Node<CoefficientPower> head = null;

            while (copy != null)
            {
                if (head == null)
                {
                    var t = RemoveMax(copy);
                    head = t.Item1;
                    copy = t.Item2;
                    new_lst = head;
                }
                else
                {
                    var t = RemoveMax(copy);
                    new_lst.SetNext(t.Item1);
                    new_lst = new_lst.GetNext();
                    copy = t.Item2;
                }  
            }

            return head;
        }

        public static int Calculate(Node<CoefficientPower> lst, int x)
        {
            int sum = 0;
            while (lst != null)
            {
                sum += lst.GetValue().GetCoefficient() * (int)Math.Pow(x, lst.GetValue().GetPower());
            }
            return sum;
        }


        public static void Print_Polynomial(Node<CoefficientPower> lst)
        {
            Console.Write("f(x) = ");

            while (lst != null)
            {
                Console.Write(lst.GetValue().GetCoefficient() + "x^" + lst.GetValue().GetPower() + "+");
                lst = lst.GetNext();
            }
        }
    }
}
