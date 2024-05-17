using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automats
{
    class Program
    {
        private static void test2_number_recognize()
        {
            System.Console.WriteLine("---- test2 number recognize ----");
            string[] Q = { "q0", "q1", "q2", "q3", "q4", "q5", "q6" };
            char[] Sigma = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.', '+', '-' };
            Trans[] passes = {
            new Trans("q0", '0', "q4"),

            new Trans("q0", '+', "q5"),
            new Trans("q0", '-', "q5"),

            new Trans("q0", '1', "q1"),
            new Trans("q0", '2', "q1"),
            new Trans("q0", '3', "q1"),
            new Trans("q0", '4', "q1"),
            new Trans("q0", '5', "q1"),
            new Trans("q0", '6', "q1"),
            new Trans("q0", '7', "q1"),
            new Trans("q0", '8', "q1"),
            new Trans("q0", '9', "q1"),

            new Trans("q5", '1', "q1"),
            new Trans("q5", '2', "q1"),
            new Trans("q5", '3', "q1"),
            new Trans("q5", '4', "q1"),
            new Trans("q5", '5', "q1"),
            new Trans("q5", '6', "q1"),
            new Trans("q5", '7', "q1"),
            new Trans("q5", '8', "q1"),
            new Trans("q5", '9', "q1"),

            new Trans("q1", '0', "q1"),
            new Trans("q1", '1', "q1"),
            new Trans("q1", '2', "q1"),
            new Trans("q1", '3', "q1"),
            new Trans("q1", '4', "q1"),
            new Trans("q1", '5', "q1"),
            new Trans("q1", '6', "q1"),
            new Trans("q1", '7', "q1"),
            new Trans("q1", '8', "q1"),
            new Trans("q1", '9', "q1"),

            new Trans("q5", '0', "q6"),
            new Trans("q4", '.', "q2"),
            new Trans("q1", '.', "q2"),
            new Trans("q6", '.', "q2"),


            new Trans("q2", '0', "q3"),
            new Trans("q2", '1', "q3"),
            new Trans("q2", '2', "q3"),
            new Trans("q2", '3', "q3"),
            new Trans("q2", '4', "q3"),
            new Trans("q2", '5', "q3"),
            new Trans("q2", '6', "q3"),
            new Trans("q2", '7', "q3"),
            new Trans("q2", '8', "q3"),
            new Trans("q2", '9', "q3"),

            new Trans("q3", '0', "q3"),
            new Trans("q3", '1', "q3"),
            new Trans("q3", '2', "q3"),
            new Trans("q3", '3', "q3"),
            new Trans("q3", '4', "q3"),
            new Trans("q3", '5', "q3"),
            new Trans("q3", '6', "q3"),
            new Trans("q3", '7', "q3"),
            new Trans("q3", '8', "q3"),
            new Trans("q3", '9', "q3"),

            };
            string Q0 = "q0";
            string[] F = { "q1", "q3" };
            var nFSM = new Automat(Sigma, F, Q0, Q, passes);

            nFSM.Check("545");
            nFSM.Check("+56");
            nFSM.Check("-50");
            nFSM.Check("6.787");
            nFSM.Check("-0.08");

            nFSM.Check("005");
            nFSM.Check(".7");
            nFSM.Check("04.5");
            nFSM.Check("-+9");
            nFSM.Check("6+2");
            nFSM.Check("-.7");
        }

        private static void Test1()
        {
            System.Console.WriteLine("---- test1 ----");
            string[] Q = { "q0", "q1", "q2", "q3" };
            char[] Sigma = { '0', '1' };
            Trans[] Delta = {
            new Trans("q0", '0', "q0"),
            new Trans("q0", '1', "q0"),
            new Trans("q0", '1', "q1"),
            new Trans("q1", '0', "q2"),
            new Trans("q1", '1', "q2"),
            new Trans("q2", '0', "q3"),
            new Trans("q2", '1', "q3"),
         };
            string Q0 = "q0";
            string[] F = { "q3" };
            var nFSM = new Automat(Sigma, F, Q0, Q, Delta);

            nFSM.Check("10");
            nFSM.Check("00000100");
            nFSM.Check("101010101001010100");
            nFSM.Check("0000010");
            nFSM.Check("000001");
            nFSM.Check("0110101010000");

        }

        static void Main(string[] args)
        {
            //test2_number_recognize();
            Test1();
        }
    }
}
