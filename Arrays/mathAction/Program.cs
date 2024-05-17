using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathAction
{
    class Program
    {
        public static int[] MathAction(int[] action)
        {
            int[] result = new int[action.Length / 3];
            int resultIndex = 0;

            for (int i = 0; i < action.Length; i += 3)
            {
                if (action[i] == 1)
                {
                    result[resultIndex] = action[i + 1] + action[i + 2];
                    resultIndex++;
                }
                else
                {
                    result[resultIndex] = action[i + 1] - action[i + 2];
                    resultIndex++;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] action = { 2, 31, 11, 1, -40, 10 };
            int[] result = MathAction(action);

            for (int i = 0; i<result.Length; i++)
            {
                Console.Write(result[i]+",");
            }
        }
    }
}
