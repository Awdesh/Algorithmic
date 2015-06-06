using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraynStrings
{
    class AreStringsAnagram
    {
        public bool AnagramStrings(string s1, string s2)
        {
            if(s1.Length != s2.Length)
            {
                return false;
            }

            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach(char elem in s1.ToCharArray())
            {
                if(!dict.ContainsKey(elem))
                {
                    dict.Add(elem, 1);
                }
            }

            foreach (char elem in s2.ToCharArray())
            {
                if(!dict.ContainsKey(elem))
                {
                    return false;
                }
                // Anagrams formed by using characters exactly once, that's why we have used "--dict[elem]" logic below.
                if(--dict[elem] == 0)
                {
                    dict.Remove(elem);
                }
            }

            return dict.Count == 0;
        }
    }
}
