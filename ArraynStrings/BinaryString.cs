using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //Given a binary string, count number of substrings that start and end with 1. For example, if the input string is “00100101”, then there are three substrings “1001”, “100101” and “101”.
    class BinaryString
    {
        // my attempt.
        //public static int numberOfSubstrings(string number)
        //{
        //    int nos = 1;
        //    char[] charArray = number.ToCharArray();
        //    int length = charArray.Length;
        //    if (length < 2)
        //    {
        //        return nos;
        //    }
        //    char[] subArray = new char[length];
        //    int j = 0;
        //    bool isFilled = false;
        //    for (int i = 0; i < length; i++)
        //    {
        //        if (charArray[i] == '1')
        //        {
        //            subArray[j] = charArray[i];
        //            if (subArray[0] != 0)
        //            {
        //                if (isFilled)
        //                {
        //                    nos++;
        //                }
        //            }
        //            j++;
        //        }
        //        else
        //        {
        //            if(subArray[0] != '\0')
        //            {
        //                subArray[j] = charArray[i];
        //                isFilled = true;
        //                j++;
        //            }
        //        }
        //    }
        //     return nos;
        //}

        public static int numberOfSubstrings(string number)
        {
            int nos = 0;
            int m = 0;
            int length = number.Length;
            for (int i = 0; i < length; i++)
            {
                if (number[i] != '0')
                {
                    m++;
                }
            }
            // when combinations are made for every other occurance then we use this formula.
            // e.g see this http://mathforum.org/library/drmath/view/61212.html
            nos = m * (m - 1) / 2;
            return nos;
        }
    }
}
