using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice;

namespace ArraynStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[1000];
            ar[0] = 1;
            ar[1] = 2;
            ar[2] = 3;
            ar[3] = 3;
            ar[4] = 3;
            ar[5] = 5;
            ar[6] = 6;
            ar[7] = 13;
            ar[8] = 14;
            ar[9] = 15;
            ar[10] = 16;
            ar[11] = 16;
            ar[12] = 16;
            ar[13] = 16;
            ar[14] = 17;
            ar[15] = 18;
            ar[16] = 19;
            ar[17] = 20;
            ar[18] = 21;

            //DuplicateElementArray.FindDuplicateElementFromArray(ar);

           // DuplicateElementArray.FindDuplicateElementFromArrayConstantSpace(ar);

            //FindNumberFromSortedArray f = new FindNumberFromSortedArray();
            //f.FindOccuranceOfNumber(ar, 16);

            //AreStringsAnagram obj = new AreStringsAnagram();
            //bool val = obj.AnagramStrings("MARY", "ARMY");
            //string s = String.Empty;
            //if (val)
            //    s = "not lying";
            //else
            //    s = "lying";
            //Console.WriteLine("Strings are anagram and i am {0} ", s);


            //CommonSubstring css = new CommonSubstring();
            //List<char> l = css.FindCommonSubstring("abcaabcdef", "de");
            //Console.WriteLine("Common Substrings are-:");
            //foreach(char e in l)
            //{
            //    Console.WriteLine("{0}", e);
            //}

            //DuplicateElementArray.FindDuplicateElementFromArray(ar);

           //RemoveDuplicateFromArray dups = new RemoveDuplicateFromArray();
           //int[] arr =  dups.RemoveDuplicate(ar);
           //Console.WriteLine("after removing duplicates new array is-: ", arr);

            //LongestIncreasingSequence lis = new LongestIncreasingSequence();
            //int[] arr = lis.FindLongestIncreasingSequence(ar);
            //Console.WriteLine("array is-: {0}", arr);

            int[] ar1 = new int[7] { 1,3,50,10,09, 7, 6 };
            GetMaxBinarySearch max = new GetMaxBinarySearch();
            int maxVal = max.GetMax(ar1);
        }
    }
}
