using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfTwoArraysII
{
    class Solution
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            var numsDic = new Dictionary<int, int>();
            var resultList = new List<int>();

            foreach(var item in nums1)
            {
                if (!numsDic.ContainsKey(item))
                    numsDic.Add(item, 1);
                else numsDic[item]++;
            }

            foreach(var item in nums2)
            {
                if (numsDic.ContainsKey(item))
                {
                    if(numsDic[item] > 1)
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
