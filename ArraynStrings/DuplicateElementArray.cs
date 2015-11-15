using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //http://www.geeksforgeeks.org/find-the-two-repeating-elements-in-a-given-array/
    class DuplicateElementArray
    {
        /// <summary>
        /// O(n) time and O(n) space. Works only if all elements must range from 1.....n.
        /// Note-: This approach is only applicable if we know range in an array beforehand(e.g. its more like Counting Sort.)
        /// </summary>
        /// {1, 2, 3, 1, 3, 0, 6}
        public static void FindDuplicateElementFromArray(int[] array)
        {
            int[] count = new int[array.Length];
            for(int i = 0; i < array.Length; i++)
            {
                if(count[array[i]] == 1)
                {
                    Console.WriteLine("dup is-:{0}", array[i] );
                }
                else
                {
                    count[array[i]]++;
                }
            }
        }

        /// <summary>
        /// O(n) time with O(1). Works only if all elements must range from 1.....n.
        /// Note-: This approach is only applicable if we know range in an array beforehand(e.g. its more like Counting Sort.)
        /// </summary>
        /// <param name="array"></param>
        public static void FindDuplicateElementFromArrayConstantSpace(int[] array)
        {
            for(int i = 0; i< array.Length; i++)
            {
                try
                {
                    if (array[Math.Abs(array[i])] > 0)
                    {
                        array[Math.Abs(array[i])] = -array[Math.Abs(array[i])];
                    }
                    else
                    {
                        Console.WriteLine("dup is-: {0}", Math.Abs(array[i]));
                    }
                }
                catch
                {
                    continue;
                }
                
            }
        }
    }
}
