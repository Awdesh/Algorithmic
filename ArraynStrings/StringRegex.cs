using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class StringRegex
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool FindSpecialCharactersUsingRegex(string str)
        {
            // ^ tells if its starting of string, $ tells if its end of string.
            System.Text.RegularExpressions.Regex regexUrl = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9_@.-]*$");
            bool val = regexUrl.IsMatch(str);
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool FindSpecialCharactersWithoutRegex(string str)
        {
            string specialCharacters = "@#$%^&*()|?";
            char[] charArray = specialCharacters.ToCharArray();

            if(str.IndexOfAny(charArray) != 0 )
            {
                return true;
            }
            return false;
        }

    }
}
