using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class NextLarger
    {
        public void FindNext(int[] arr)
        {
            int l = arr.Length;
            Array.Sort(arr);

            for(int i = 0; i + 1 < l; i++)
            {
                if (arr[i + 1] > arr[i])
                    Console.WriteLine("Next larger int of {0} is {1}",arr[i], arr[i + 1]);
            }

            Console.WriteLine("Next larger int of {0} is {1}", arr[l-1], -1);
        }
    }
}
