using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraynStrings
{
    class GetMaxBinarySearch
    {
        public int GetMax(int[] input)
        {
            int max = 0;
            if(input.Length <= 0)
            {
                return max;
            }

            int start = 0;
            int end = input.Length - 1;

            while(start <= end)
            {
                // mid = (start + end) / 2, if array size is more than 2^30 then start + end value go beyond integer range and gives random -negative value.
                int mid = start + (end - start) / 2;

                if(mid > 0 && mid < input.Length - 1)
                {
                    if (input[mid] > input[mid - 1] && input[mid] > input[mid + 1])
                    {
                        max = input[mid];
                        return max;
                    }

                    if (input[mid] > input[mid - 1] && input[mid] < input[mid + 1])
                    {
                        start = mid + 1;
                    }

                    if (input[mid] < input[mid - 1] && input[mid] > input[mid + 1])
                    {
                        end = mid - 1;
                    }
                }
                else
                {
                    max = input[mid];
                    return max;
                }
            }
            return -1;
        }
    }

    
}
