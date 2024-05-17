using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4
{
    class MrtnRace
    {
        private string country;
        private int yearMrtn;
        private Node<MrtnRunner> lstM;

        public MrtnRace(string country, int yearMrtn, Node<MrtnRunner> lstM)
        {
            this.country = country;
            this.yearMrtn = yearMrtn;
            this.lstM = lstM;
        }

        public string GetCountry()
        {
            return this.country;
        }

        public int GetYearMrtn()
        {
            return this.yearMrtn;
        }

        public Node<MrtnRunner> GetLstM()
        {
            return this.lstM;
        }

        public void UpdateRunnerScore(string id, int score)
        {
            Node<MrtnRunner> runner = this.lstM;
            while (runner.GetValue().GetID() != id)
                runner = runner.GetNext();

            Node<ItemMrtn> pos = runner.GetValue().GetLst();
            while(pos.GetNext() != null)
            {
                pos = pos.GetNext();
            }
            pos.SetNext(new Node<ItemMrtn>(new ItemMrtn(this.yearMrtn, score)));
        }
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
}
