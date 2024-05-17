using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4
{
    class InternalRoundNode
    {

        public static Node<T> IntersectionPoint<T>(Node<T> rLst)
        {
            Node<T> turtle = rLst;
            Node<T> rabbit = rLst;

            bool found_intersect = true;

            while (rabbit.GetNext().GetNext() != null && found_intersect)
            {
                for (int i = 0; i < 2; i++)
                    rabbit = rabbit.GetNext();

                turtle = turtle.GetNext();

                found_intersect = rabbit != turtle;
            }

            if (rabbit == turtle)
                return rabbit;

            return null;
        }

        public static Node<T> CrossSection<T>(Node<T> lst)
        {
            Node<T> intersect = IntersectionPoint(lst);

            while (intersect != lst)
            {
                intersect = intersect.GetNext();
                lst = lst.GetNext();
            }

            return intersect;
        }

        public static void PrintLoopRoundList<T>(Node<T> lst)
        {
            Node<T> intersect = IntersectionPoint(lst);
            while (lst != intersect)
            {
                Console.Write(lst.GetValue() + "-->");
                lst = lst.GetNext();
            }

            Console.Write("(");
            Console.Write(lst + "-->");
            lst = lst.GetNext();

            while (lst != intersect)
            {
                Console.Write(lst + "-->");
                lst = lst.GetNext();
            }

            Console.Write(")");
        }

    }
}
