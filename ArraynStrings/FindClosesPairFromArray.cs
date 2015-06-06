using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class FindClosesPairFromArray
    {
        public int[] FindPair(int[] array1, int[] array2, int x)
        {
            int len1 = array1.Length;
            int len2 = array2.Length;

            int[] pair = new int[2];

            int i = 0;
            int j = 0;
            int sum = 0;
            while (i < len1 && j < len2)
            {
                if (array2[j] < array1[i])
                {
                    if (array1[i] < x)
                    {
                        sum = array1[i] + array2[j];
                    }
                    else
                    {
                        pair[0] = array1[i-1];
                        pair[1] = array2[j];
                        return pair;
                    }
                    i++;
                }
                if(array2[j] > array1[i])
                {
                    if(array2[j] < x)
                    {
                        sum = array2[j] + array1[i];
                    }
                    else
                    {
                        pair[0] = array1[i];
                        pair[1] = array2[j - 1];
                        return pair;
                    }
                    j++;
                }
                else
                {
                    i++;
                    sum = array2[i] + array2[j - 1];
                    if(sum < x)
                    {
                        pair[0] = array1[i-1];
                        pair[1] = array2[j - 1];
                        return pair;
                    }
                }
            } 
            return pair;
        }
    }
}
