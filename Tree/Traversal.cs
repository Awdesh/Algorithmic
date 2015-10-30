using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tree;

namespace Practice
{
    public class Traversal
    {
        //NLR
        /// <summary>
        /// Using Stack to represent PreOrder operation over Tree.
        /// </summary>
        /// <param name="root"></param>
        public void PreOrderTraversalWithoutRecusrion(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Stack<TreeNode> s = new Stack<TreeNode>();
            // In all traversal we push root TreeNode first into the stack.
            s.Push(root);
            TreeNode temp;
            Console.WriteLine("PreOrder traversal is-:");
            while(s.Count > 0)
            {
                // we print the TreeNode whenever we Pop from stack
                temp = s.Pop();
                if( temp == null )
                {
                    break;
                }
                Console.WriteLine(temp.getData());
                // here print happens after children insertion that's why we insert Right into stack first so that it can be printed after left.
                // whereas in Inorder we push all left TreeNodes first then we start popping them out and print them( which will print root too.)
                if( temp.getRight() != null )
                {
                    s.Push(temp.getRight());
                }
                if (temp.getLeft() != null)
                {
                    s.Push(temp.getLeft());
                }
            }
        }

        //LNR
        /// <summary>
        /// step-1-: In this we push left TreeNodes of left subtree inside stack first and find left child of them, 
        /// step-2-: then we start popping them out one by one, while popping out we look for their right child( we dont need to find left child since its already been inserted)
        /// step-3-: if right child found then follow above line (we push it in stack and find its left child), 
        /// </summary>
        /// <param name="root"></param>
        public void InorderTraversalWithoutRecursion(TreeNode root)
        {
            if ( root == null)
            {
                return;
            }
            Stack<TreeNode> s = new Stack<TreeNode>();
            TreeNode temp = root;
            bool done = false;
            Console.WriteLine("Inorder traversal is-:");
            while(!done)
            {
                // we need if.. else here since we need to dig deep down in one of the subtree first.
                // whereas in preOrder case we have "NLR" according to which we need same algo because we need to go through right child too.
                if(temp  != null)
                {
                    s.Push(temp);
                    temp = temp.getLeft();
                }
                else
                {
                    if(s.Count>0)
                    {
                        // we print the TreeNode whenever we Pop from stack
                        temp = s.Pop();
                        Console.WriteLine(temp.getData());
                        temp = temp.getRight();
                    }
                    else
                    {
                        done = true;
                    }
                }
            }
        }

        //LRN
        //public void PostorderTraversalWithoutRecursion( TreeNode root )
        //{
        //    Stack<TreeNode> s = new Stack<TreeNode>();
        //    if ( root == null )
        //    {
        //        return;
        //    }
        //    s.Push(root);
        //    TreeNode temp = root;
        //    while(!s.isEmpty())
        //    {
        //        if(temp)
        //        {
        //            s.Push(temp);
        //            temp = temp.getRight();
        //        }
        //    }

        //}

        // BFS and preorder implementation are mostly same.
        // BFS uses queue and inside while we do getLeft() first because queue is FIFO whereas Stack on LIFO.
        public void BFSTraversal(TreeNode root)
        {
            if ( root == null )
            {
                return;
            }
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            TreeNode curr;
            Console.WriteLine("BFS traversal is-: ");
            while (q.Count > 0)
            {
                curr = q.Dequeue();
                Console.WriteLine(curr.getData());
                if(curr.getLeft() != null)
                {
                    q.Enqueue(curr.getLeft());
                }
                if(curr.getRight() != null)
                {
                    q.Enqueue(curr.getRight());
                }
            }
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        public void InorderTraversalWithRecursion(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            InorderTraversalWithRecursion(root.getLeft());
            Console.WriteLine(root.getData());
            InorderTraversalWithRecursion(root.getRight());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        public void PreOrderTraversalRecursion(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Console.WriteLine(root.getData());
            PreOrderTraversalRecursion(root.getLeft());
            PreOrderTraversalRecursion(root.getRight());

    
        }
    }
}
