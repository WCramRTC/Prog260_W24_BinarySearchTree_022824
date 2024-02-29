using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog260_W24_BinarySearchTree_022824
{
    public class BSTExample
    {
        public class TreeNode
        {
            public int Data;
            public TreeNode Left;
            public TreeNode Right;

            public TreeNode(int data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }

        private TreeNode _root;

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

        public void LevelOrderTraversal()
        {
            if (_root == null)
            {
                Console.WriteLine("Tree is empty.");
                return;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(_root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                Console.Write("Level " + levelSize + ": ");

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

        public void BreadthFirstTraversal()
        {
            if (_root == null)
            {
                Console.WriteLine("Tree is empty.");
                return;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(_root);

            while (queue.Count > 0)
            {
                TreeNode current = queue.Dequeue();
                Console.Write(current.Data + " ");

                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }

                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }

                Console.WriteLine();
            }
        }

        // Example: In-order traversal (left-root-right)
        public void InOrderTraversal(TreeNode node)
        {
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

            Console.Write(node.Data + " ");
            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
        }

        public void PostOrderTraversal()
        {
            PostOrderTraversal(_root);
        }

        // Other traversal methods (pre-order, post-order) can be added similarly.
    }
}
