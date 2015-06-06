using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraynStrings
{
    class RemoveDuplicateFromArray
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] RemoveDuplicate(int[] arr)
        {
            if(arr.Length == 0)
            {
                return arr;
            }

            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach(int elem in arr)
            {
                if(!dict.ContainsKey(elem))
                {
                    dict.Add(elem, 1);
                }
                else
                {
                    dict[elem] = 2;
                }
            }

            int[] newArr = new int[dict.Count];
            int i = 0;
            foreach(var pair in dict)
            {
                newArr[i] = pair.Key;
                i++;
            }
            return newArr;
        }

        /// <summary>
        /// inplace
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        //public int[] RemoveDuplicatesInplace(int[] arr)
        //{
        //    int count = 0;
        //    for(int i = 0; i <arr.Length; i++)
        //    {
        //        int j = 0;
        //        while(j <arr.Length)
        //        {
        //            if(arr[i] == arr[j])
        //            {
        //                count++;
        //            }
        //            j++;
        //        }
        //    }
        //    return arr;
        //}

        public class Solution
        {
            public Tuple<int, int> TwoSum(int[] numbers, int target)
            {
                int Length = numbers.Length;
                int sum = numbers[0];
                if (sum > target || Length == 0)
                {
                    return null;
                }

                for (int i = 0; i < Length; i++)
                {
                    if (numbers[i] == target)
                    {
                        var tuple = Tuple.Create(i, i);
                        return tuple;
                    }
                    if (numbers[i + 1] < target)
                    {
                        sum = sum + numbers[i + 1];
                        if (sum == target)
                        {
                            var tuple = Tuple.Create(i, i);                           
                            return tuple;
                        }
                    }
                    break;
                }
                return null;
            }
        }

    }
}
