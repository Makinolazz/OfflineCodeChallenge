using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OfflineCodeChallenge
{
    public static class InputArrayTool
    {
        public static int[] BuildIntArray(string input)
        {
            var resultArray = input.Trim().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            return resultArray;
        }

        public static int[] SetNegativeValues(int[] storedArray)
        {
            for (int i = 0; i < storedArray.Length; i++)
            {
                storedArray[i] = storedArray[i] * -1;
            }

            return storedArray;
        }

        public static int[] SumArraysItems(int[] arrayA, int[] arrayB)
        {
            int[] shortestArray;
            int[] result;

            if (arrayA.Length <= arrayB.Length)
            {
                result = arrayB;
                shortestArray = arrayA;
            }
            else
            {
                result = arrayA;
                shortestArray = arrayB;
            }

            for (int i = 0; i < shortestArray.Length; i++)
            {
                result[i] += shortestArray[i];
            }

            return result;
        }
    }
}
