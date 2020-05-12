namespace IntersectionOfTwoArraysII
{
    internal class Program
    {
        // Given two arrays, write a function to compute their intersection.
        private static void Main(string[] args)
        {
            var nums1 = new int[] {1, 2, 2, 1 };
            var nums2 = new int[] { 2, 2 };
            Solution.Intersect(nums1, nums2);
        }
    }
}
