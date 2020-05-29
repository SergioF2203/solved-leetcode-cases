using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoIntegers
{
    internal class Solution
    {
        public static int GetSum(int a, int b)
        {
            var min = a > b ? b : a;
            var max = a > b ? a : b;

            for (var i = 0; i <max; i++)
                min++;
            return min;

            //var aBin = GetBinary(a);
            //var bBin = GetBinary(b);
            //AddBinary(aBin, bBin);
            //return 0;
        }

        private static int[] GetBinary(int _num)
        {
            var valueStack = new Stack<int>();

            while (_num >= 2)
            {
                valueStack.Push(_num % 2);
                _num = _num / 2;
            }
            valueStack.Push(_num);

            var resultArray = new int[valueStack.Count];

            for (var i = 0; i < valueStack.Count; i++)
            {
                resultArray[i] = valueStack.Pop();
            }

            return resultArray.ToArray();
        }

        private static int[] AddBinary(int[] _firstBinArray, int[] _secondBinArray)
        {
            var temp1Stack = new Stack<int>();
            for (int i = 0; i < _firstBinArray.Length; i++)
            {
                temp1Stack.Push(_firstBinArray[i]);
            }

            var temp2Stack = new Stack<int>();
            for (int i = 0; i < _secondBinArray.Length; i++)
            {
                temp2Stack.Push(_secondBinArray[i]);
            }

            var tempStack = new Stack<int>();
            tempStack.Push(0);

            var resultStack = new Stack<int>();
            while (temp1Stack.Count != 0 || temp2Stack.Count != 0)
            {
                var temp1 = temp1Stack.Count == 0 ? 0 : temp1Stack.Pop();
                var temp2 = temp2Stack.Count == 0 ? 0 : temp2Stack.Pop();

                switch (temp1 + temp2 + tempStack.Pop())
                {
                    case 0:
                        resultStack.Push(0);
                        break;
                    case 1:
                        resultStack.Push(1);
                        break;
                    case 2:
                        resultStack.Push(0);
                        tempStack.Push(1);
                        break;
                    default:
                        break;
                }
            }

            return resultStack.ToArray();
        }

    }
}
