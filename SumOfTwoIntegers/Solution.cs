using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoIntegers
{
    internal class Solution
    {
        public static int GetSum(int a, int b)
        {
            if ((a < 0 && b >= 0) || (a >= 0 && b < 0) || (a >= 0 && b >= 0))
            {
                var min = a > b ? b : a;
                var max = a > b ? a : b;

                for (var i = 0; i < max; i++)
                    min++;
                return min;
            }

            for (var i = 0; i < Math.Abs(b); i++)
                a--;
            return a;
        }
    }
}
