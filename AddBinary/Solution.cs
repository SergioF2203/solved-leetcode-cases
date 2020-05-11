using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddBinary
{
    class Solution
    {
        public static string AddBinary(string a, string b)
        {
            if (string.IsNullOrWhiteSpace(a) || string.IsNullOrWhiteSpace(b)) return string.Empty;
            if (a == "0" && b == "0") return "0";
            Stack<char> aS = new Stack<char>();
            Stack<char> bS = new Stack<char>();

            foreach (var item in a)
                aS.Push(item);

            foreach (var item in b)
                bS.Push(item);

            string result = string.Empty;

            Stack<char> resStack = new Stack<char>();
            resStack.Push('0');
            while (aS.Count != 0 || bS.Count != 0)
            {
                var tempA = aS.Count == 0 ? '0' : aS.Pop();
                var tempB = bS.Count == 0 ? '0' : bS.Pop();

                var tempStack = resStack.Pop();
                switch (tempA + tempB + tempStack)
                {
                    case 144:
                        resStack.Push('0');
                        resStack.Push('0');
                        break;
                    case 145:
                        resStack.Push('1');
                        resStack.Push('0');
                        break;
                    case 146:
                        resStack.Push('0');
                        resStack.Push('1');
                        break;
                    case 147:
                        resStack.Push('1');
                        resStack.Push('1');
                        break;
                    default:
                        aS.Clear();
                        bS.Clear();
                        resStack.Clear();
                        break;
                }
            }

            if (resStack.Count != 0)
            {

                if (resStack.Peek() == '0')
                    resStack.Pop();
                char[] resArray = new char[resStack.Count];
                int count = 0;
                while (resStack.Count != 0)
                {
                    resArray[count] = resStack.Pop();
                    count++;
                }

                result = new string(resArray);
            }

            return result;
        }
    }
}
