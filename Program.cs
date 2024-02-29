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
            BSTExample bt = new BSTExample();

            for (int i = 0; i < 10; i++)
            {
                bt.Add(i);
            }


            Console.Write("In Order Traversal:");
            bt.InOrderTraversal();

            Console.WriteLine();
            Console.Write("Pre Order Traversal:");
            bt.PreOrderTraversal();


            Console.WriteLine();
            Console.Write("Post Order Traversal:");
            bt.PostOrderTraversal();

            Console.WriteLine();
            Console.WriteLine("Level Traversal");
            bt.LevelOrderTraversal();
        }
    }
}
