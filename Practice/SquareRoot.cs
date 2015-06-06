using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class SquareRoot
    {
        public static int findsquareroot(int number)
        {
            int result = 0;
            for (int i = 0; i <= number / 2; i++ )
            {
                result = i * i;
                if( result == number )
                {
                    return i;
                }
                else if ( result > number)
                {
                    return i - 1;
                }
            }
            return 0;
        }

        /// <summary>
        /// Newton raphson's method. Best way.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static double findSquareRootPrecision(int number)
        {
            double result = 0;
            result = findRoot(number, 1);
            return result;
        }

        private static double findRoot(double x, double g)
        {
            if(closeEnough(x/g, g))
            {
                return g;
            }
            else
            {
                // Result of betterGuess will keep on decreasing with each call.
                return findRoot(x, betterGuess(x, g));
            }
        }

        private static bool closeEnough(double x, double g)
        {
            return (Math.Abs(x - g) < 0.001);
        }

        private static double betterGuess(double x, double g)
        {
            return ((g + x / g) / 2);
        }
    }
}
