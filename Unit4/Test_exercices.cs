using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4
{
    class Test_exercices
    {
        public static void Test_Waves()
        {
            int[] a = {8, 10, 7, 25, 27, -2, -3, 18, 23};
            Console.WriteLine(exercices.Waves(a));
        }

        public static void Test_UpdateLst()
        {
            int[] a = { 3, 0, 0, -5, 7, -10, 0, 0, 12, 0 };
            Node<int> lst = NodeUtils.CreateListFromArray(a);
            NodeUtils.PrintList(lst);
            exercices.UpdateLst(lst);
            NodeUtils.PrintList(lst);
        }
    }
}
