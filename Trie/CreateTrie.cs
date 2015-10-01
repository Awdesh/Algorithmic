using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    /// <summary>
    /// Class responsible for creating a trie structure.
    /// </summary>
    class CreateTrie
    {
        public class Node
        {
            public string Word;
            public bool IsTerminal
            {
                get
                {
                    return Word != null;
                }
            }
            public Dictionary<char, Node> Edges = new Dictionary<char, Node>();
        }

        public Node root = new Node();

        /// <summary>
        /// Constructor taking in an array of words and creating "Trie" from it.
        /// </summary>
        /// <param name="words"></param>
        public CreateTrie(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                var node = root;
                for (int len = 1; len <= word.Length; len++)
                {
                    var letter = word[len - 1];
                    Node next;
                    if (!node.Edges.TryGetValue(letter, out next))
                    {
                        next = new Node();
                        if (len == word.Length)
                        {
                            // will set full word to node's word member.
                            next.Word = word;
                        }
                        node.Edges.Add(letter, next);
                    }
                    node = next;
                }
            }
        }
    }
}
