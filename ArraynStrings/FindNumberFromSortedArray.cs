using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraynStrings
{
    /// <summary>
    /// 
    /// </summary>
    class FindNumberFromSortedArray
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="num"></param>
        public void FindOccuranceOfNumber(int[] arr, int num)
        {
            int index = 0;
            if(arr[0] == num)
            {
                GetCount(arr, index,num);
            }
            for(int i = 5; i<arr.Length; i+=5)
            {
                if(arr[i] >= num)
                {
                    index = BinarySearch(arr,i-5 , i, num);
                    break;
                }
                else if(arr[i] < num)
                {
                    index = BinarySearch(arr, i,i+5, num);
                    break;
                }
            }
            GetCount(arr, index, num);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="index"></param>
        /// <param name="num"></param>
        public void GetCount(int[] arr, int index, int  num)
        {
            int count = 0;
            int aftercount = 0;
            int prevcount = 0;
            int i = index;
            while (arr[i] == num)
            {
                i++;
                aftercount++;
            }
            i = index;
            while (arr[i-1] == num)
            {
                if (index == 0)
                    break;
                i--;
                prevcount++;
            }
            count = prevcount + aftercount;
            Console.WriteLine("Count is-:{0}", count);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="num"></param>
        public int BinarySearch(int[] arr, int start, int end, int num)
        {
            while(end >=start)
            {
                int mid = (start + end) / 2;
                if(arr[mid] == num)
                {
                    return mid;
                }
                if (arr[mid] > num)
                {
                    end = mid - 1;
                }
                else if(arr[mid] < num)
                {
                    start = mid + 1;
                }
            }
            return -1;
        }
    }
}
