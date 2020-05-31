using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimbingStairs
{
    class Solution
    {
        public static int ClimbStairs(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 2;

            int summ = 1;
            int prev = 1;
            int temp;

            for (int i = 1; i < n; i++)
            {
                temp = summ;
                summ += prev;
                prev = temp;
            }

            return summ;
        }
    }
}
