using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Palindrome
    {
        // Recursion.
        public static bool IsPalindromeViaRecursion(int n)
        {
            string s = n.ToString();
            if (s.Length <= 1) return true;
            return (s.First() == s.Last()) && IsPalindromeViaRecursion(int.Parse(s.Substring(1, s.Length - 2)));
        }

        //
        /// <summary>
        /// Chcek whether a number is palindrome or not.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool IsPalindrome(int num)
        {
            string st = num.ToString();
            char[] arr = st.ToCharArray();
            int len = arr.Length;
            if (len <= 1)
            {
                return false;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == arr[len - 1])
                {
                    if (i >= len)
                    {
                        return true;
                    }
                    len--;
                }
                else
                {
                    break;
                }
            }
            return false;

            // Another method to test palindrome.Stack Overflow.
            //n = num;
            // rev = 0;
            // while (num > 0)
            // {
            //      dig = num % 10;
            //      rev = rev * 10 + dig;
            //      num = num / 10;
            // }
            //If n == rev then num is a palindrome:

            //cout << "Number " << (n == rev ? "IS" : "IS NOT") << " a palindrome" << endl;

            // Another approach can be-:
            // reverse a string then compare with original string, if both equal then palindrome.
        }
    }
}
