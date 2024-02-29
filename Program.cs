using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog260_W24_BinarySearchTree_022824
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BST bst = new BST();

            bst.Add(42); // Daniel
            bst.Add(7); // Jonathan
            bst.Add(63); // Meili
            bst.Add(3); // Ronda
            bst.Add(4); // Will
            bst.Add(12); // Ednalynn

            Console.WriteLine("In Order Traversal");
            bst.InOrderTraversal();

            Console.WriteLine("\n");
            Console.WriteLine("Preorder Traversal");
            bst.PreOrderTraversal();


            Console.WriteLine("\n");
            Console.WriteLine("PostOrder Traversal");
            bst.PostOrderTraversal();

            Console.WriteLine();

            //bst.LevelOrderTraversal();
            // BFS - 42, 7, 63, 3, 12, 4


            //BSTExample bt = new BSTExample();

            //for (int i = 0; i < 10; i++)
            //{
            //    bt.Add(i);
            //}


            //Console.Write("In Order Traversal:");
            //bt.InOrderTraversal();

            //Console.WriteLine();
            //Console.Write("Pre Order Traversal:");
            //bt.PreOrderTraversal();


            //Console.WriteLine();
            //Console.Write("Post Order Traversal:");
            //bt.PostOrderTraversal();

            //Console.WriteLine();
            //Console.WriteLine("Level Traversal");
            //bt.LevelOrderTraversal();
        }
    }
}
