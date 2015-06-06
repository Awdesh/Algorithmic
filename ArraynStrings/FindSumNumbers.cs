using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    // FB question-: find whether an array contains numbers such that sum of any 2 numbers when gets added with the third number in an array returns 0.
    class FindSumNumbers
    {
        public static bool IsSumExists(int[] arr)
        {
            int length = arr.Length;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int val = 1;
            foreach(int num in arr)
            {
                if(!dict.ContainsKey(num))
                {
                    dict.Add(num, val);
                    val++;
                }
            }
            for (int i = 0; i < length-1; i++ )
            {
                int j = 1;
                int sum = 0;
                while(j<length-1)
                {
                    sum = arr[i] + arr[j];
                    // here we check if dictionary contains same value and by putting -ve sign in front of it we make sure that it'll make total SUM to zero.
                    if(dict.ContainsKey(-sum))
                    {
                        return true;
                    }
                    j++;
                }
            }
            return false;
        }
    }
}
