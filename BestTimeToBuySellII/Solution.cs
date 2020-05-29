using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestTimeToBuySellII
{
    class Solution
    {
        public static int MaxProfit2(int[] prices)
        {
            var maxProfit = 0;

            if (prices.Length == 0) return maxProfit;

            var minBuy = prices[0];

            var stackProfit = new Stack<int>();
            stackProfit.Push(0);

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < minBuy) minBuy = prices[i];
                var res = prices[i] - minBuy;

                if (stackProfit.Peek() <= res)
                {
                    stackProfit.Pop();
                    stackProfit.Push(res);
                }
                else
                {
                    stackProfit.Push(0);
                    minBuy = prices[i];
                }
            }

            while (stackProfit.Count > 0)
                maxProfit += stackProfit.Pop();

            return maxProfit;
        }
    }
}
