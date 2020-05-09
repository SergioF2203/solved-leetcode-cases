using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfTwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given two arrays, write a function to compute their intersection.
            var nums1 = new[] { 1, 2, 2, 1 };
            var nums2 = new[] { 2, 2 };

            Solution.Intersection(nums1, nums2);
        }
    }
}
