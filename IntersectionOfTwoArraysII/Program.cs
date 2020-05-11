using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfTwoArraysII
{
    class Program
    {
        // Given two arrays, write a function to compute their intersection.
        static void Main(string[] args)
        {
            var nums1 = new int[] {1, 2, 2, 1 };
            var nums2 = new int[] { 2, 2 };
            Solution.Intersect(nums1, nums2);
        }
    }
}
