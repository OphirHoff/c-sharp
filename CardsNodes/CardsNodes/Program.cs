using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;

namespace CardsNodes
{
    internal class Program
    {
        public static void SortByValue(Node<Card> lst)
        {
            int cnt = 0;
            Node<Card> pos = lst;

            while(pos.GetNext() != null)
            {
                Node<Card> prev = pos.GetNext();
                Node<Card> scan = pos.GetNext().GetNext();

                while(scan != null)
                {
                    if (scan.GetValue().GetNum() == pos.GetValue().GetNum())
                    {
                        prev.SetNext(scan.GetNext());
                        scan.SetNext(pos.GetNext());
                        pos.SetNext(scan);
                        pos = pos.GetNext();
                        scan = prev.GetNext();
                    }

                    else
                    {
                        prev = scan;
                        scan = scan.GetNext();
                    }
                }
                cnt++;
                pos = pos.GetNext();
            }

            pos.SetNext(new Node<Card>(new Card(cnt, "white")));
        }

        static void Main(string[] args)
        {

            Card[] cards_arr = { new Card(3, "green"), new Card(4, "red"), new Card(2, "red"), new Card(7, "blue"), new Card(4, "yellow"), new Card(7, "yellow"), new Card(3, "green"), new Card(3, "red") };

            Node<Card> cards = NodeUtils.CreateListFromArray(cards_arr);

            NodeUtils.PrintList(cards);

            SortByValue(cards);

            NodeUtils.PrintList(cards);

        }
    }
}
