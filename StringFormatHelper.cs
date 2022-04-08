using System;
using System.Collections.Generic;
using System.Text;

namespace OfflineCodeChallenge
{
    public static class StringFormatHelper
    {
        public static string RemoveMinusSign(string input)
        {
            return input.Replace('-', ' ').Trim();
        }
    }
}
