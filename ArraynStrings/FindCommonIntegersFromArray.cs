using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class FindCommonIntegersFromArray
    {
        /// <summary>
        /// O(n^2)
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        public List<int> FindCommonIntegersMethod1(int[] array1, int[] array2)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < array1.Length; i++ )
            {
                int j = 0;
                while(j< array2.Length)
                {
                    if(array2[j] == array1[i])
                    {
                        list.Add(array2[j]);
                    }
                    j++;
                }
            }
            return list;
        }

        /// <summary>
        /// O(n), when arrays are already sorted.
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        public List<int> FindCommonIntegerMethod1Improvement(int[] array1, int[] array2)
        {
            List<int> list = new List<int>();
            int m = array1.Length;
            int n = array2.Length;
            int i = 0;
            int j = 0;
            while(i < n && j < m)
            {
                if(array1[i] < array2[j])
                {
                    i++;
                }
                else if (array1[i] > array2[j])
                {
                    j++;
                }
                else
                {
                    list.Add(array2[j]);
                    i++;
                    j++;
                }
            }
            return list;
        }

        /// <summary>
        /// O(m+n)
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        public List<int> FindCommonIntegerMethod2(int[] array1, int[] array2)
        {
            List<int> list = new List<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for( int i = 0; i <array1.Length; i++)
            {
                if(!dict.ContainsKey(array1[i]))
                {
                    dict.Add(array1[i], 1);
                }
            }

            for (int i = 0; i < array2.Length; i++ )
            {
                if(dict.ContainsKey(array2[i]))
                {
                    list.Add(array2[i]);
                }
            }
            return list;
        }
    }
}
