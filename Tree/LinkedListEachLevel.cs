using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree;

namespace Practice
{
    class LinkedListEachLevel
    {
        Dictionary<int, LinkedList<TreeNode>> dict = new Dictionary<int, LinkedList<TreeNode>>();
        public Dictionary<int,LinkedList<TreeNode>> FindMaxHeight(TreeNode root)
        {
            if (root == null)
            {
                return dict;
            }
            root.level = 0;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            TreeNode curr;
            int currentHeight = 0;
            // BFS traversal.
            while (q.Count > 0)
            {
                curr = q.Dequeue();
                CreateLinkedList(curr.level, curr);

                if (curr.getLeft() != null)
                {
                    curr.getLeft().level = currentHeight + 1;
                    q.Enqueue(curr.getLeft());
                }
                if (curr.getRight() != null)
                {
                    curr.getRight().level = currentHeight + 1;
                    q.Enqueue(curr.getRight());
                }
            }

            foreach (LinkedList<TreeNode> ll in dict.Values)
            {
                ll.Count();
                Console.WriteLine("{0}", ll);
            }
            return dict;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="level"></param>
        /// <param name="node"></param>
        public void CreateLinkedList(int level, TreeNode node)
        {
            if (!dict.ContainsKey(level))
            {
                LinkedList<TreeNode> linkedList = new LinkedList<TreeNode>();
                linkedList.AddLast(node);
                dict.Add(level, linkedList);
            }
            else
            {
                LinkedList<TreeNode> ll = dict[level];
                ll.AddLast(node);
            }
        }
    }
}
