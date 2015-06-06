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

        using System;
using System.Collections;

namespace MSSelection
{
    public class PrintPaths
    {
        public PrintPaths ()
        {
        }

                // Prints all paths to leaf  
        public static void printAllPathsToLeaf(TreeNode node, int[] path, int index) {  
            if ( node == null )  
                return;  

            // storing data in array  
            path[index] = node.data;  
            index++;  

            if(node.left == null && node.right == null) {  
                // leaf node is reached  
                printArray(path,index);  
                return;  
            }  

            printAllPathsToLeaf(node.left, path, index);  
            printAllPathsToLeaf(node.right, path, index);  
        }

        /* Utility that prints out an array on a line */
        void printArray(int[] ints, int index)
        {
            int i;
            for (i=0; i<index; i++) {
                printf("%d ", ints[i]);
            }
            printf("\n");
        } 


    }
}



        // Recursive. PreOrder traversal.
        //private void doPrint(TreeNode node, List<TreeNode> path) {
        //    if (node == null) return;

        //    path.add(node);

        //    if (node.left == null && node.right == null) {
        //        System.out.println("Path from root: " + root.item + " to leaf: " + node.item + " - ");
        //        for (TreeNode treeNode : path) {
        //            System.out.print(treeNode.item + " ");
        //        }
        //        System.out.println();
        //    }
        //    doPrint(node.left , path);
        //    doPrint(node.right, path);

        //    path.remove(path.size() - 1);
        //}
    }
}
