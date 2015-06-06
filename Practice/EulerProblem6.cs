using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class EulerProblem6
    {
        public static double findDifference()
        {
            double difference = 0;
            difference = SquaresOfSum(100) - SumofSquares(100);
            return difference;
        }

        public static double SumofSquares(int n)
        {
            double sum = 0;
            sum = n * (n + 1) * (2 * n + 1) / 6;
            return sum;
        }

        public static double SquaresOfSum(int n)
        {
            double sum = 0;
            sum = n * (n + 1) / 2;
            sum = Math.Pow(sum, 2);
            return sum;
        }
    }
}
