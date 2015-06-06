using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class MedianOfTwoSortedArrays
    {
        public int FindMedian(int[] ar1, int[] ar2)
        {
            int median = 0;
            int length1 = ar1.Length;
            FindMedianArray1(ar1, length1);
            return median;
        }


        public int[] FindMedianArray1(int[] ar, int length)
        {
            int median = 0;

            if(length <= 2)
            {
                return ar;
            }
            median = ar[length / 2];
            length = length / 2;
            ar[0] = ar[length];
            FindMedianArray1(ar, length / 2);
            return ar;
        }
    }
}
