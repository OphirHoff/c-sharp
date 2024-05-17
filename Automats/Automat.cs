using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automats
{
    class Automat
    {
        private char[] Sigma;
        private string[] states;
        private string q0;
        private string[] accepting_states;
        private Trans[] trans;

        public Automat(char[] sigma, string[] states, string q0, string[] accepting_states, Trans[] trans)
        {
            Sigma = sigma;
            this.states = states;
            this.q0 = q0;
            this.accepting_states = accepting_states;
            this.trans = trans;
        }

        private string GetNextState(string curr, char ch)
        {
            for (int i = 0; i < trans.Length; i++)
            {
                if (this.trans[i].GetCurr() == curr && this.trans[i].GetCh() == ch)
                    return this.trans[i].GetNext();
            }
            return "";
        }

        public void Check(string word)
        {
            string curr = this.q0;
            for (int i = 0; i < word.Length; i++)
            {
                curr = GetNextState(curr, word[i]);
            }

            for (int i = 0; i < this.accepting_states.Length; i++)
            {
                if (this.accepting_states[i] == curr)
                {
                    Console.WriteLine("True");
                    return;
                }
            }

            Console.WriteLine("False");
        }
    }
}
