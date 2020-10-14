using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Cosmos.Core.Extension
{
    public static class StringExtension
    {
        public static bool IsPhoneNo(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;
            if (input.Length != 11)
                return false;

            if (new Regex(@"^1[3578][01379]\d{8}$").IsMatch(input)
                || new Regex(@"^1[34578][01256]\d{8}").IsMatch(input)
                || new Regex(@"^(1[012345678]\d{8}|1[345678][0123456789]\d{8})$").IsMatch(input)
                )
                return true;
            return false;
        }
    }
}
