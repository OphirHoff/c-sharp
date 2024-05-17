using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4
{
    class RoundNodeUtils
    {
        public static void MakeListRound<T>(Node<T> lst)
        {
            Node<T> head = lst;

            while (lst.GetNext() != null)
            {
                lst = lst.GetNext();
            }

            lst.SetNext(head);
        }

        public static void PrintRoundList<T>(Node<T> lst)
        {

            Node<T> pos = lst.GetNext();

            Console.Write(lst + "-->");

            while (pos != lst)
            {
                Console.Write(pos + "-->");
                pos = pos.GetNext();
            }
        }

        public static void DisconnectRoundList<T>(Node<T> lst)
        {
            Node<T> pos = lst.GetNext();

            while (pos.GetNext() != lst)
            {
                pos = pos.GetNext();
            }

            pos.SetNext(null);
        }

        public static bool IsRoundList<T>(Node<T> head)
        {
            Node<T> pos = head.GetNext();

            while (pos != head && pos != null)
            {
                pos = pos.GetNext();
            }

            return pos == head;
        }

        public static int ListLength<T>(Node<T> head)
        {
            Node<T> pos = head.GetNext();
            int cnt = 1;

            while (pos != head)
            {
                pos = pos.GetNext();
                cnt++;
            }

            return cnt;
        }

        public static int SumList(Node<int> head)
        {
            Node<int> pos = head.GetNext();

            int sum = head.GetValue();

            while(pos != head)
            {
                sum += pos.GetValue();
                pos = pos.GetNext();
            }

            return sum;
        }

        public static Node<T> RemoveHead<T>(Node<T> head)
        {
            Node<T> pos = head;

            while(pos.GetNext() != head)
            {
                pos = pos.GetNext();
            }

            pos.SetNext(head.GetNext());
            return pos.GetNext();
        }

        public static void RemoveLast<T>(Node<T> head)
        {
            Node<T> pos = head;

            while (pos.GetNext().GetNext() != head)
            {
                pos = pos.GetNext();
            }

            pos.SetNext(head);
        }

        public static bool IsExist(Node<int> head, int value)
        {
            Node<int> pos = head.GetNext();

            bool found = false;

            while (pos != head && !found)
            {
                found = pos.GetValue() == value;
                pos = pos.GetNext();
            }

            return found;
        }

        public static Node<int> RemoveEven(Node<int> head)
        {
            Node<int> last = head;
            Node<int> pos = head.GetNext();

            while (pos != head)
            {
                if (pos.GetValue() % 2 == 0)
                {
                    last.SetNext(pos.GetNext());
                }

                else
                    last = pos;
                
                pos = pos.GetNext();
            }

            if (pos.GetValue() % 2 == 0)
            {
                last.SetNext(pos.GetNext());
                return pos.GetNext();
            }

            return head;
        }

        public static void AddToEven(Node<int> head)
        {
            Node<int> last = head;
            Node<int> pos = head.GetNext();

            while(pos != head)
            {
                if (pos.GetValue() % 2 == 0)
                {
                    last.SetNext(new Node<int>(pos.GetValue() - 1));
                    last.GetNext().SetNext(pos);
                    last = pos;
                }

                else
                    last = pos;

                pos = pos.GetNext();
            }

            if (pos.GetValue() % 2 == 0)
            {
                last.SetNext(new Node<int>(pos.GetValue() - 1));
                last.GetNext().SetNext(pos);
            }

        }

        public static Node<T> AddToLoop<T>(Node<T> head, Node<T> new_node)
        {
            Node<T> pos = head.GetNext();

            while (pos.GetNext() != head)
                pos = pos.GetNext();

            pos.SetNext(new_node);
            new_node.SetNext(head);

            return new_node; // new_node => new list head
        }

        public static void SumNeighbors(Node<int> head)
        {
            Node<int> last = head;
            Node<int> pos = head.GetNext();

            while(pos != head)
            {
                AddToLoop(pos, new Node<int>(last.GetValue() + pos.GetValue()));
                last = pos;
                pos = pos.GetNext();
            }
            AddToLoop(pos, new Node<int>(last.GetValue() + pos.GetValue()));
        }

        public static bool HasLoop<T>(Node<T> head)
        {
            Node<T> curr = head;
            Node<T> next = head.GetNext();
            Node<T> next_next = next.GetNext();

            while (next != null && curr != next_next)

            {
                next.SetNext(curr);

                curr = next;
                next = next_next;
                if (next_next != null)
                    next_next = next_next.GetNext();
            }

            bool foundLoop = curr == next_next;

            return foundLoop;
        }

        public static void CreateLoopList<T>(Node<T> lst, int n)
        {
            Node<T> pos = lst;
            for (int i = 0; i < n; i++)
            {
                pos = pos.GetNext();
            }

            while (lst.GetNext() != null)
                lst = lst.GetNext();

            lst.SetNext(pos);
        }

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
            while(lst != intersect)
            {
                Console.Write(lst.GetValue() + "-->");
                lst = lst.GetNext();
            }

            Console.Write("(");
            Console.Write(lst + "-->");
            lst = lst.GetNext();    

            while(lst != intersect)
            {
                Console.Write(lst + "-->");
                lst = lst.GetNext();
            }

            Console.Write(")");
        }
    }
}
