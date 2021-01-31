using System;

namespace FindAllNumbersDisappearedInAnArray
{
    class Program
    {
        // Given an array of integers where 1 ≤ a[i] ≤ n(n = size of array), some elements appear twice and others appear once.
        // Find all the elements of [1, n] inclusive that do not appear in this array.
        static void Main(string[] args)
        {
            var res = Solution.FindDisappearedNumbers(new int[] { 4, 3, 3, 2, 2, 1, 7, 8 });
        }
    }
}
