using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackspaceStringCompare
{
    class Program
    {
        // Given two strings S and T, return if they are equal when both are typed into empty text editors. # means a backspace character.

        static void Main(string[] args)
        {
            var string1 = "ab#c";
            var string2 = "ad#c";

            Solution.BackspaceCompare(string1, string2);
        }
    }
}
