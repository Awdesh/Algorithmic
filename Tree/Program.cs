using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class TreeNode
    {
        int data;
        private TreeNode left;
        private TreeNode right;
        public int level;

        public TreeNode(int data)
        {
            this.data = data;
        }

        public TreeNode getLeft()
        {
            return left;
        }

        public TreeNode getRight()
        {
            return right;
        }

        public int getData()
        {
            return data;
        }

        public TreeNode CreateBinaryTree()
        {
            TreeNode rootNode = new TreeNode(40);
            TreeNode node20 = new TreeNode(20);
            TreeNode node10 = new TreeNode(10);
            TreeNode node30 = new TreeNode(30);
            TreeNode node60 = new TreeNode(60);
            TreeNode node50 = new TreeNode(50);
            TreeNode node70 = new TreeNode(70);
            TreeNode node5 = new TreeNode(5);
            TreeNode node55 = new TreeNode(55);

            rootNode.left = node20;
            rootNode.right = node60;

            node20.left = node10;
            node20.right = node30;

            node60.left = node50;
            node60.right = node70;
            node10.left = node5;
            node50.right = node55;

            return rootNode;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            TreeNode node = new TreeNode();
            TreeNode root = node.CreateBinaryTree();
            Practice.MaxHeight mh = new Practice.MaxHeight();
            int height = mh.FindMaxHeight(root);
            Console.WriteLine("{0}", height);
            //CountLeafNodes count = new CountLeafNodes();
            //int c = count.TotalLeafNodes(node.CreateBinaryTree());
        }
    }
}
