using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class DecimalToBinary
    {
        public char[] ConvertFromDecimal(int decimalVal, int baseVal)
        {
            // Decimal to binary.
            int remainder = 0;
            StringBuilder sb = new StringBuilder();
            while (decimalVal > 0)
            {
                remainder = decimalVal % baseVal;
                sb.Append(remainder);
                decimalVal = decimalVal / baseVal;
            }
            string s = sb.ToString();
            char[] chArray = s.ToCharArray();
            Array.Reverse(chArray);
            return chArray;
        }

        public void ConvertOctal(int Octal, int baseVal)
        {
            // Octal To Binary.

        }
    }
}
