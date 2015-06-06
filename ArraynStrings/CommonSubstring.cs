using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraynStrings
{
    class CommonSubstring
    {
        /// <summary>
        /// O(n)
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public List<char> FindCommonSubstring(string s1, string s2)
        {
            if(s1.Length < 0 || s2.Length < 0)
            {
                return null;
            }
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char elem in s1.ToCharArray())
            {
                if (!dict.ContainsKey(elem))
                    dict.Add(elem, 1);
            }
            List<char> ll = new List<char>();
            foreach (char elem in s2.ToCharArray())
            {
                if (dict.ContainsKey(elem))
                {
                    ll.Add(elem);
                }
            }
            return ll;
        }
    }
}
