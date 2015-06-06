using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraynStrings
{
    class LongestIncreasingSequence
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        public int[] FindLongestIncreasingSequence(int[] arr)
        {
            int prev = 0;
            int last = 0;
            int longest = 0;
            int maxDiff = 0;
            int[] arr1 = new int[2];
            for(int i = 0; i + 1 < arr.Length; i++)
            {
                if(arr[i] < arr[i+1])
                {
                    if(prev == 0)
                        prev = i;
                    last = i + 1;
                    if (longest < last - prev)
                    {
                        longest = last - prev;
                        if (longest >= maxDiff)
                        {
                            maxDiff = longest;
                            arr1[0] = prev;
                            arr1[1] = last;
                        }
                    }
                }
                else
                {
                    prev = 0;
                    last = 0;
                }
            }
            return arr1;
        }
    }
}
