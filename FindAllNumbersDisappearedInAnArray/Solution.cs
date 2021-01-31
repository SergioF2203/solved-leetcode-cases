using System;
using System.Collections.Generic;
using System.Text;

namespace FindAllNumbersDisappearedInAnArray
{
    static class Solution
    {
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] > 0) 
                    nums[index] = -nums[index];
            }

            List<int> result = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0) 
                    result.Add(i + 1);
            }

            return result;
        }
    }
}
