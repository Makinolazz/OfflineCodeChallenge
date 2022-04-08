using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OfflineCodeChallenge
{
    public static class InputValidator
    {
        public static bool IsEmptyInput(string input)
        {
            if (string.IsNullOrEmpty(input.Trim()))
            {
                return true;
            }

            return false;
        }

        public static bool IsNegativeInput(string input)
        {
            return input[0].Equals('-') ? true : false; ;
        }

        public static bool HasInvalidData(int[] array)
        {
            return array.Any(x => x == -1) ? true : false;
        }
    }
}
