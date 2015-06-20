using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class GroupAnagrams
    {
        public void Group(Dictionary<string, int> map)
        {
            List<string> l = new List<string>();
            List<List<string>> ll = new List<List<string>>();
            foreach(string word in map.Keys)
            {
                int len = word.Length;
                l = Lookup(map,len,word);
                ll.Add(l);
            }
        }

        public List<string> Lookup(Dictionary<string,int> map, int l, string w)
        {
            Dictionary<char, int> wordMap = new Dictionary<char,int>();
            foreach(char c in w)
            {
                if(!wordMap.ContainsKey(c))
                    wordMap.Add(c,1);
                else
                    wordMap.Add(c,2);
            }

          List<string> list = new List<string>();

            foreach(string word in map.Keys)
            {
                bool found = false;

                if(l == word.Length && word !=  w)
                {
                    foreach(char c in word)
                    {
                        if (!wordMap.ContainsKey(c))
                        {
                            found = false;
                            break;
                        }
                        else
                            found = true;
                    }
                }
                if(found)
                    list.Add(word);
            }

            Console.WriteLine("Anagram of word {0} is-:", w);
            foreach(string s in list)
            {
                Console.WriteLine("{0}", s);
            }
 

            return list;
        }
    }
}
