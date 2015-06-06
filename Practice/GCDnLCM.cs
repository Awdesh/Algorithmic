using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class GCDnLCM
    {
        public int FindGCD(int a, int b)
        {
            int gcd = 0;
            for (int i = Math.Min(a, b); i >= 1; i-- )
            {
                if(a%i == 0 || b%i==0)
                {
                    return i;
                }
            }
            return gcd;
        }

        // a = 2336 and b = 1314
        /// <summary>
        /// Euclid's algorithm.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// 1314, 292
        /// 292,146
        /// 146, 0
        public int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }

        public int LCM(int a, int b)
        {
           return b * a / GCD(a, b);
        }
    }
}
