using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Miscellaneous
{
	class AreStringsAnagram
	{
		public bool AnagramStrings(string s1, string s2)
		{
			Dictionary<char, int> dict = new Dictionary<char, int>();
			foreach(char elem in s1.ToUpper().ToCharArray())
			{
				if(!dict.ContainsKey(elem))
				{
					dict.Add(elem, 1);
				}

				else
					dict[elem] = dict[elem] + 1;
			}

			foreach (char elem in s2.ToUpper().ToCharArray())
			{
				if(dict.ContainsKey(elem))
				{
					if (dict [elem] == 1) {
						dict.Remove (elem);
						continue;
					}

					dict[elem] = dict[elem] - 1;
				}
			}
			return dict.Count == 0;
	   }
  }
}
