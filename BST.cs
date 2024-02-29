using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog260_W24_BinarySearchTree_022824
{
    // 1. Create a new class for our binary tree
    public class BST
    {
         // 2. Create an internal class called TreeNode
        public class TreeNode
        {
            int _data;
            TreeNode? _left;
            TreeNode? _right;

            public int Data { get => _data; set => _data = value; }
            public TreeNode Left { get => _left; set => _left = value; }
            public TreeNode Right { get => _right; set => _right = value; }

            public TreeNode(int data)
            {
                _data = data;
                _left = null;
                _right = null;
            }
        } // TreeNode

        TreeNode? _root;

        public BST()
        {

            _root = null;

        } // BST()

        // Add Method

        public void Add(int data)
        {
            _root = Insert(_root, data);
        }

        private TreeNode Insert(TreeNode root, int data)
        {
            if (root == null)
            {
                // Create a new node and return it.
                return new TreeNode(data);
            }


            if (data < root.Data)
            {
                root.Left = Insert(root.Left, data);
            }
            else
            {
                root.Right = Insert(root.Right, data);
            }

            return root;
        }


        // Example: In-order traversal (left-root-right)
        public void InOrderTraversal(TreeNode node)
        {
            // A node with no child nodes is a leaf
            if (node == null)
                return;

            InOrderTraversal(node.Left);
            Console.Write(node.Data + " ");
            InOrderTraversal(node.Right);
        }

        public void InOrderTraversal()
        {
            InOrderTraversal(_root);
        }

        // Example: Pre-order traversal (left-root-right)
        public void PreOrderTraversal(TreeNode node)
        {
            if (node == null)
                return;

            Console.Write(node.Data + " ");
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }

        public void PreOrderTraversal()
        {
            PreOrderTraversal(_root);
        }

        // Example: Post_Order traversal (left-root-right)
        public void PostOrderTraversal(TreeNode node)
        {
            if (node == null)
                return;


            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.Write(node.Data + " ");
        }

        public void PostOrderTraversal()
        {
            PostOrderTraversal(_root);
        }


        public void LevelOrderTraversal()
        {
            if (_root == null)
            {
                Console.WriteLine("Tree is empty.");
                return;
            }

            //// Create a Queue that holds our Tree Nodes
            //Queue<TreeNode> queue = new Queue<TreeNode>();
            //// First thing that we Enqueue, is our root
            //queue.Enqueue(_root);

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(_root);

            // While loop will KEEP LOOPING as long as there are any nodes in the queue.
            while (queue.Count > 0)
            {

                int levelSize = queue.Count; 
                Console.Write("Level " + levelSize + ": ");// <---- Not Required: Demonstration Code

                for (int i = 0; i < levelSize; i++)
                {
                    TreeNode current = queue.Dequeue();
                    Console.Write(current.Data + " ");

                    if (current.Left != null)
                    {
                        queue.Enqueue(current.Left);
                        Console.Write("(L) ");
                    }

                    if (current.Right != null)
                    {
                        queue.Enqueue(current.Right);
                        Console.Write("(R) ");
                    }
                }

                Console.WriteLine();
            }
        }


    } // class

} // namespace
