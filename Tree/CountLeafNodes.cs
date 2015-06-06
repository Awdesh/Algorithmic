using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class CountLeafNodes
    {
        public int TotalLeafNodes(TreeNode root)
        {
            if (root == null)
                return 0;
            if (root.getRight() == null && root.getLeft() == null)
                return 1;
            else
             return TotalLeafNodes(root.getLeft()) + TotalLeafNodes(root.getRight());
        }
    }
}
