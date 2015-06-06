using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class MoveZeroAtEnd
    {
        /// <summary>
        /// O(n) time and O(1) memory
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] MoveZeroAtEndOfArray(int[] arr)
        {
            int count = 0;
            int Length = arr.Length;
            for(int i = 0; i <Length; i++)
            {
                if(arr[i] != 0 )
                {
                    arr[count] = arr[i];
                    count++;
                }
            }
            while(count < Length)
            {
                arr[count] = 0;
                count++;
            }
            return arr;
        }
    }
}
