using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class PrintDuplicateValues
    {
        public static List<int> PrintDuplicateValue(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> ll = new List<int>();
            int Length = arr.Length;
            for (int i = 0; i < Length; i++ )
            {
                if(!dict.ContainsKey(arr[i]))
                {
                    dict.Add(arr[i], 1);
                }
                else
                {
                    dict[arr[i]] = 2;
                }
            }
            foreach( int key in dict.Keys)
            {
                if(dict[key] == 2)
                {
                    ll.Add(key);
                }
            }
            return ll;
        }
    }
}
