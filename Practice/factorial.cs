using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class factorial
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int FindFactorial(int number)
        {
            int factorial = 1;
            if( number <= 1)
            {
                return factorial;
            }
            factorial = number;
            for (int i = number - 1; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        /// <summary>
        /// Recursion is slower than iteration.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int FactorialUsingRecursion(int number)
        {
            // Base case.
            if(number == 1)
            {
                return 1;
            }
            
            // (n-1) denotes that problem is decrementing with each recursion.
            return number * FactorialUsingRecursion(number-1);
        }
    }
}
