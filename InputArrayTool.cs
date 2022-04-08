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
            //LINQ to turn string into a char[] and then select each item as int in an int[]
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

            //Find the shortest array
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

            //Use shortest array length to iterate throught the longest array, sum items values and keep the rest
            for (int i = 0; i < shortestArray.Length; i++)
            {
                result[i] += shortestArray[i];
            }

            return result;
        }
    }
}
