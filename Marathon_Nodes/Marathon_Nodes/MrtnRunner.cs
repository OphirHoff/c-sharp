using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4
{
    class MrtnRunner
    {
        private string id;
        private int yearB;
        Node<ItemMrtn> lst;

        public MrtnRunner(string id, int yearB, Node<ItemMrtn> lst)
        {
            this.id = id;
            this.yearB = yearB;
            this.lst = lst;
        }

        public string GetID()
        {
            return this.id;
        }

        public int GetYearB()
        {
            return this.yearB;
        }

        public Node<ItemMrtn> GetLst()
        {
            return this.lst;
        }



    }
}
