using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;

namespace Marathon_Nodes
{
    internal class Program
    {

        public static void Test_UpdateRunnerScore()
        {
            Node<ItemMrtn> mrtns = new Node<ItemMrtn>(new ItemMrtn(2011, 50));
            mrtns.SetNext(new Node<ItemMrtn>(new ItemMrtn(2012, 40)));
            mrtns.GetNext().SetNext(new Node<ItemMrtn>(new ItemMrtn(2013, 35)));

            NodeUtils.PrintList(mrtns);

            Node<MrtnRunner> runners = new Node<MrtnRunner>(new MrtnRunner("123", 2007, mrtns));

            MrtnRace race = new MrtnRace("Israel", 2020, runners);

            race.UpdateRunnerScore("123", 55);

            NodeUtils.PrintList(mrtns);
        }

        public static int MrtnSeq(MrtnRace race)
        {
            int cnt = 0;
            Node<MrtnRunner> runners = race.GetLstM();

            while (runners != null)
            {
                Node<ItemMrtn> mrtn = runners.GetValue().GetLst();
                bool is_seq = true;

                while (is_seq && mrtn.GetNext() != null)
                {
                    is_seq = mrtn.GetValue().GetYear() == mrtn.GetNext().GetValue().GetYear() - 1;
                    mrtn = mrtn.GetNext();
                }

                if (is_seq) cnt++;
                runners = runners.GetNext();
            }
            return cnt;
        }

        public static void Test_MrtnSeq()
        {
            Node<ItemMrtn> mrtns = new Node<ItemMrtn>(new ItemMrtn(2011, 50));
            mrtns.SetNext(new Node<ItemMrtn>(new ItemMrtn(2012, 40)));
            mrtns.GetNext().SetNext(new Node<ItemMrtn>(new ItemMrtn(2013, 35)));

            NodeUtils.PrintList(mrtns);

            Node<MrtnRunner> runners = new Node<MrtnRunner>(new MrtnRunner("123", 2007, mrtns));

            MrtnRace race = new MrtnRace("Israel", 2020, runners);

            Console.WriteLine(MrtnSeq(race));
            NodeUtils.PrintList(mrtns);
        }

        static void Main(string[] args)
        {
            Test_UpdateRunnerScore();
            Test_MrtnSeq();
        }
    }
}
