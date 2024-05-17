using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulPgia
{
    class BulHit
    {

        private string[] options;
        private bool[] valid;
        private string guess;
        private int guessIndex;

        public BulHit()
        {
            this.options = new string[5040];

            int indexCnt = 0;

            for (int i = 0; i < 10000; i++)
            {
                if (IsRepeatingDigits(i.ToString("D4")) == false)
                {
                    this.options[indexCnt] = i.ToString("D4");
                    indexCnt++;

                }

            }

            this.valid = new bool[5040];
            for (int i = 0; i < valid.Length; i++)
            {
                this.valid[i] = true;
            }
            
        }

        public void RandomOption()
        {
            Random rnd = new Random();
            guessIndex = rnd.Next(0, 5040);
            
            // find a valid guess option
            while(valid[guessIndex] == false)
            {
                guessIndex = rnd.Next(0, 5040);
            }

            this.guess = options[guessIndex];
        }

        // This method return true if there is a repeating digit in a number
        private bool IsRepeatingDigits(string num)
        {
            // Go over the 4 digits of the number
            for (int i = 0; i < num.Length; i++)
            {
                // for each digits check how many times is in the number
                char digit = num[i];

                int cnt = 0;
                for (int j = 0; j < num.Length; j++)
                {
                    if (num[j] == digit)
                        cnt++;
                }
                if (cnt > 1)
                    return true;
            }
            return false;
        }

        public string GetGuess()
        {
            return this.guess;
        }


        // Minimize the valid options
        public bool LessOptions(int hit, int bul)
        {
            if (bul == 4)
                return true;

            valid[guessIndex] = false;

            int findHit=0;
            int findBul=0;
            for (int i = 0; i < this.options.Length; i++)
            {
                if (valid[i] == true)
                {
                    string option = this.options[i];

                    for (int j = 0; j < 4; j++)
                    {
                        char digit = this.guess[j];

                        // Check Bul
                        if (digit == option[j])
                            findBul++;

                        // Check Pgia
                        else if (option.Contains(guess[j]))
                            findHit++;
                    }

                    this.valid[i] = (findBul == bul && findHit == hit);
                    findBul = 0;
                    findHit = 0;
                }
            }
            return false;
        }
    }
}
