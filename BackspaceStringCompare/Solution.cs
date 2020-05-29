using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackspaceStringCompare
{
    class Solution
    {
        public static bool BackspaceCompare(string S, string T)
        {
            if (string.IsNullOrEmpty(S) || string.IsNullOrEmpty(T)) return false;

            var stackFirstString = new Stack<char>();
            var stackSecondString = new Stack<char>();

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '#' && stackFirstString.Count > 0)
                    stackFirstString.Pop();
                else if (S[i] == '#') continue;
                else stackFirstString.Push(S[i]);
            }

            for (int i = 0; i < T.Length; i++)
            {
                if (T[i] == '#' && stackSecondString.Count > 0)
                    stackSecondString.Pop();
                else if (T[i] == '#') continue;
                else stackSecondString.Push(T[i]);
            }

            if (stackFirstString.Count != stackSecondString.Count) return false;
            while (stackFirstString.Count > 0)
                if (stackFirstString.Pop() != stackSecondString.Pop()) return false;

            return true;

        }
    }
}
