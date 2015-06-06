using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class SievePrime
    {
        /// <summary>
        /// Find all prime numbers of a number n.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool[] Sieve(int n)
        {
            bool[] prime = new bool[n + 1];
            prime[0] = false;
            prime[1] = false;
            for (int i = 2; i < n; i++ )
            {
                prime[i] = true;
            }
            double m = Math.Sqrt(n);
            // Increase multiple.
            for(int i = 2; i <= m; i++)
            {
                if(prime[i])
                {
                    // set false flag for all multiple.
                    for(int k = i * i; k <=n; k+=i)
                    {
                        prime[k] = false;
                    }
                }
            }
            return prime;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsPrime(int n)
        {
            bool isPrime = false;
            if (n <= 1)
                return isPrime;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return isPrime;
            int m = Convert.ToInt32(Math.Sqrt(n));
            for (int i = 3; i <= m; i+=2 )
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
