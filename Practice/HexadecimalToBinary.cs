using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class HexadecimalToBinary
    {
        public static string ConvertHexaDecimalToBinray(Object HexaDecimalNumber)
        {
            string str = HexaDecimalNumber.ToString();
            char[] charArray = str.ToCharArray();
            int length = charArray.Length;
            Object value;
            StringBuilder b = new StringBuilder();

            for (int i = 0; i < length; i++ )
            {
                Dictionary<Object, Object> d = FillDictionary();
                if(d.ContainsKey(charArray[i]))
                {
                   value = d[charArray[i]];
                   b.Append(value);
                }
            }
            return b.ToString();
        }

        private static Dictionary<Object, Object> FillDictionary()
        {
            // Imp. to remember that use Object, Object inside dictionary.
            // otherwise dict. treats 0010 as 10.
            // could have used char, string in this case too.
            Dictionary<Object, Object> dict = new Dictionary<Object, Object>();
            dict.Add('1', "0000");
            dict.Add('2', "0010");
            dict.Add('3', "0011");
            dict.Add('4', "0100");
            dict.Add('5', "0101");
            dict.Add('6', "0110");
            dict.Add('7', "0111");
            dict.Add('8', "1000");
            dict.Add('9', "1001");
            dict.Add('A', "1010");
            dict.Add('B', "1011");
            dict.Add('C', "1100");
            dict.Add('D', "1101");
            dict.Add('E', "1110");
            dict.Add('F', "1111");

            return dict;
        }
    }
}
