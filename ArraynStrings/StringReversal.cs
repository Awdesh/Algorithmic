using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class StringReversal
    {
        /// <summary>
        /// using array.Reverse() method.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReverseString(string str)
        {
            string st = String.Empty;
            char[] arr = st.ToCharArray();
            arr.Reverse();
            st = arr.ToString();
            return st;
        }

        /// <summary>
        /// InPlace reversal.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReverseStringInPlace(string str)
        {
            string s = String.Empty;
            char[] charArray = str.ToCharArray();
            int end = charArray.Length - 1;
            int start = 0;
            while (end > start)
            {
                char temp = charArray[end];
                charArray[end] = charArray[start];
                charArray[start] = temp;
                end--;
                start++;
            }
            return charArray.ToString();
        }

        /// <summary>
        /// Using recursion.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string ReverseStringUsingRecursion(string word)
        {
            if ((word == null) || (word.Length <= 1))
            {
                return word;
            }
            //Pass1: reverse("user") : return reverse("ser")+'u';

            //Pass2: reverse("ser")+'u' : return reverse("er")+'s'+'u';

            //Pass3: reverse("er")+'s'+'u' : return reverse("r")+'e'+'s'+'u';

            //Pass4: reverse("r")+'e'+'s'+'u' : return 'r'+'e'+'s'+'u'; // because here "r".length()==1
            // Substring(int startIndex), this gives string with the start index till the end Index, i.e. complete length of the string.
            // word.Substring(1) = ser where 'u' = 0, 's' = 1, 'e' = 2, 'r' = 3.
            // Substring method extracts string.
            return ReverseStringUsingRecursion(word.Substring(1)) + word[0];
        }
    }
}
