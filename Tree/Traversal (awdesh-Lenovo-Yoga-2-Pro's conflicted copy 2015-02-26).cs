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
        /// 
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
            TreeNode temp = root;
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
                // here print happens after chilfren insertion that's why we insert Right into stack first so that it can be printed after left.
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

            if (root == null) 
            {
                return;
            }
            Stack<TreeNode> s = new Stack<TreeNode> ();
            bool done = false;
            TreeNode temp = root;
            // have to use this flag instead of stack count.
            while (!done) 
            {
                if (temp != null) 
                {
                    // Keep digging deep inside left subtree.
                    s.Push (temp);
                    temp = temp.getLeft ();
                }
                // When no more left children left then start popping out of stack.
                // Code inside else statement is more like PreOrder's if code.
                else
                {
                    if (s.Count > 0) 
                    {
                        temp = s.Pop ();
                        if (temp == null) 
                        {
                            break;
                        }
                        Console.WriteLine (temp.getData ());
                        temp = temp.getRight ();
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
                if(curr == null)
                {
                    break;
                }
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
