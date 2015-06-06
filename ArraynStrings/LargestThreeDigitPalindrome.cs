using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    //Find the largest palindrome made from the product of two 3-digit numbers.
    class LargestThreeDigitPalindrome
    {
        public static int LargestPalindrome()
        {
            int number = 0;
            for (int i = 999; i > 100; i--)
            {
                int j = 900;
                while ( j > 99 )
                {
                    // Brute Force..
                    number = i * j;
                    LargestThreeDigitPalindrome lp = new LargestThreeDigitPalindrome();
                    if (lp.IsPalindrome(number))
                    {
                        return number;
                    }  
                    j--;
                }
            }
            return number;
        }

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
        }
    }
}
