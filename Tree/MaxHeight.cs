using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree;

namespace Practice
{
    class MaxHeight
    {
        public int FindMaxHeight(TreeNode root)
        {
            int height = 0;
            if (root == null)
            {
                return height;
            }
            root.level = 0;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            TreeNode curr;
            int maxHeight = 0;
            int currentHeight = 0;
            // BFS traversal.
            while (q.Count > 0)
            {
                curr = q.Dequeue();
                currentHeight = curr.level;

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
                if (maxHeight < currentHeight)
                {
                    maxHeight = currentHeight;
                }
            }
            return maxHeight;
        }
    }
}
