using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Yahtzee
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="toss"></param>
        /// <returns></returns>
        public int maxPoints(int[] toss)
        {
            int max = 0;
            Dictionary<int,int> dict = new Dictionary<int,int>();
            foreach(int face in toss)
            {
                if(!dict.ContainsKey(face))
                {
                    dict.Add(face, 1);
                }
                else
                {
                    int val = dict[face];
                    val = val + 1 ;
                    dict[face] = val;
                }
            }

            foreach(KeyValuePair<int,int> pair in dict)
            {
                if(pair.Key * pair.Value > max)
                {
                    max = pair.Key * pair.Value;
                }
            }
            return max;
        }

        /// <summary>
        /// Top Coder answers awesome. uses dice property of 1.. 6 face so loop over then and for each numer in an array iterate one by one.
        /// </summary>
        /// <param name="toss"></param>
        /// <returns></returns>
        public int maxPointsArr(int[] toss)
        {
            int max = 0;
            for (int i = 1; i <= 6; i++ )
            {
                int j = 0;
                //todo.
                int sum = 0;
                while(j <toss.Length)
                {
                    if(toss[j] == i)
                    {
                        sum = sum +  toss[j];
                    }
                    j++;
                }
                max = Math.Max(max, sum);
            }
           return max;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="toss"></param>
        /// <returns></returns>
        public int maxPointsAnother(int[] toss)
        {
            int best = 0;
            int max = 0;

            for (int i = 0; i < toss.Length; i++)
            {
                best = 0;
                int m = toss[i];

                for (int j = 0; j < toss.Length; j++)
                {
                    // below if will execute for the value itself so best will always has some number.
                    if (m == toss[j])
                    {
                        best += m;
                    }
                }

                if (best > max)
                {
                    max = best;
                }
            }

            return max;
        }

    }
}
