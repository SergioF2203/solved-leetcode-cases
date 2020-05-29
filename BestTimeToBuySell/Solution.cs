using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestTimeToBuySell
{
    class Solution
    {
        public static int MaxProfit(int[] prices)
        {
            if (prices.Length == 0) return 0;

            int res = 0;
            int min = prices[0];

            for (int i = 1; i < prices.Length - 1; i++)
            {
                if (prices[i] < min) min = prices[i];
                res = prices[i + 1] - min > res ? prices[i + 1] - min : res;
            }

            return res;
        }
    }
}
