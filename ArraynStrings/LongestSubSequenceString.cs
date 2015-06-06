using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class LongestSubSequenceString
    {
        public static string FindLongestSubSequence(String str)
        {
        	// str = "abbcbcba"
        	//char[] chArray = [a,b,c]
            char[] charArray = str.ToCharArray();
            List<char> list = new List<char>();
            int count = 0;
            int longestSize = 0;
            String longestSoFar = String.Empty;
            for(int i = 0; i < charArray.Length; i++)
            {
                if(!list.Contains(charArray[i]))
                {
                    list.Add(charArray[i]);
                    count++;
                }
                else
                {
                    if(count > longestSize)
                    {
                        longestSize = count;
                        count = 0;
                    }
                    if( i == charArray.Length - 1)
                    {
                        StringBuilder builder = new StringBuilder();
                        foreach( char c in list)
                        {
                            builder.Append(c);
                        }
                        return builder.ToString();
                    }
                    list.Clear();
                }
            }
            return String.Empty;
        }
    }
}
