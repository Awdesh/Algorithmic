using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree;

namespace Practice
{
    class FindNodeTree
    {
        public TreeNode FindNodeInTree(TreeNode root, int value)
        {
            if( root == null )
            {
                return null;
            }
            TreeNode curr = root;
            while(true)
            {
                if( root.getData() == value)
                {
                    return root;
                }
                else if( root.getData() > value)
                {
                    root = root.getLeft();
                }
                else
                {
                    root = root.getRight();
                }
            }
        }
    }
}
