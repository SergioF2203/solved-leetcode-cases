
namespace IntersectionOfTwoArrays
{
    using System.Collections.Generic;

    public class Solution
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            var numsDic = new Dictionary<int, int>();
            var intersectionList = new List<int>();

            foreach (var item in nums1)
            {
                if (!numsDic.ContainsKey(item))
                    numsDic.Add(item, 0);
            }

            foreach (var item in nums2)
            {
                if (numsDic.ContainsKey(item))
                {
                    intersectionList.Add(item);
                    numsDic.Remove(item);
                }
            }

            return intersectionList.ToArray();
        }
    }
}
