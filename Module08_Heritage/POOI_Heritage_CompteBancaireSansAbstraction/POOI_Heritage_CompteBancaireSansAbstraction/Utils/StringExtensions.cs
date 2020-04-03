using System;
using System.Collections.Generic;
using System.Text;

namespace POOI_Heritage_CompteBancaireSansAbstraction.Utils
{
    public static class StringExtensions
    {
        // source : https://stackoverflow.com/questions/17590528/pad-left-pad-right-pad-center-string
        public static string PadBoth(this string p_str, int p_length)
        {
            int spaces = p_length - p_str.Length;
            int padLeft = spaces / 2 + p_str.Length;
            return p_str.PadLeft(padLeft).PadRight(p_length);
        }
    }
}
