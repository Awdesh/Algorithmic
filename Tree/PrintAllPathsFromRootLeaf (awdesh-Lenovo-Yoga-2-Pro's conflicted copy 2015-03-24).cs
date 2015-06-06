using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree;

namespace Practice
{
    class PrintAllPathsFromRootLeaf
    {
        public void PrintPaths( TreeNode root )
        {
            if( root == null )
            {
                return;
            }
            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);
            TreeNode curr;
            Console.WriteLine("Path from root to leaf is-:");
            while(s.Count > 0)
            {
                curr = s.Pop();
                if (curr == null)
                    break;
                Console.WriteLine(curr.getData());

                if(curr.getRight() != null)
                {
                    s.Push(curr);
                }
                if(curr.getLeft() !=  null)
                {
                    s.Push(curr.getLeft());
                }
            }
        }
    }

    public void FindTotalCuts(TreeNode root)
    {
        
    }
}
