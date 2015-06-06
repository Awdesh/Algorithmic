using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    // Write an efficient function to find the first nonrepeated character in a string. For
    //instance, the first nonrepeated character in “total” is ‘o’ and the first nonrepeated
    //character in “teeter” is ‘r’. Discuss the efficiency of your algorithm.
    class NonRepeatedChars
    {
        public static char NonRepeatedChar(string str)
        {
            char c = ' ';
            char[] charArray = str.ToCharArray();
            int length = charArray.Length;
            if (length < 1)
            {
                return c;
            }
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < length; i++)
            {
                if(dict.ContainsKey(charArray[i]))
                {
                    // add multiple value to a key.
                    dict[charArray[i]] = 2;
                }
                else
                {
                    dict.Add(charArray[i], 1);
                }
            }
            // remember to use KeyValuePair for such data structures.
            // foreach( var key in dict.Keys) can be used too.
            foreach (KeyValuePair<char, int> pair in dict )
            {
                if (pair.Value == 1)
                {
                    c = pair.Key;
                    return c;
                }
            }
            return c;
        }
    }
}
