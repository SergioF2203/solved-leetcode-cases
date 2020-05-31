using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows
{
    class Solution
    {
        public static string GetHint(string secret, string guess)
        {
            var bulls = 0;
            var cows = 0;

            bool[] used = new bool[secret.Length];
            int[] frequency = new int[10];

            for (int i = 0; i < secret.Length; ++i)
            {
                if (secret[i] == guess[i])
                {
                    used[i] = true;
                    ++bulls;
                }
                else
                {
                    frequency[secret[i] - '0'] += 1;
                }
            }

            for (int i = 0; i < guess.Length; ++i)
            {
                if (!used[i] && frequency[guess[i] - '0'] > 0)
                {
                    ++cows;
                    frequency[guess[i] - '0'] -= 1;
                }
            }


            return $"{bulls}A{cows}B";
        }

    }
}
