namespace IntersectionOfTwoArraysII
{
    using System.Collections.Generic;

    internal class Solution
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0 || nums2.Length == 0) return null;

            var numsDic = new Dictionary<int, int>();
            var resultList = new List<int>();

            foreach (var item in nums1)
            {
                if (!numsDic.ContainsKey(item))
                    numsDic.Add(item, 1);
                else numsDic[item]++;
            }

            foreach (var item in nums2)
            {
                if (numsDic.ContainsKey(item))
                {
                    if (numsDic[item] > 1)
                    {
                        numsDic[item]--;
                        resultList.Add(item);
                    }
                    else
                    {
                        resultList.Add(item);
                        numsDic.Remove(item);
                    }
                }
            }

            return resultList.ToArray();
        }
    }
}
