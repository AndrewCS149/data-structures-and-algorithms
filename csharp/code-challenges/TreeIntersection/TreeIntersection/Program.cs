using System;
using System.Collections.Generic;
using Trees;

namespace TreeIntersection
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // TREE ONE
            BinarySearchTree tree = new BinarySearchTree();
            tree.Root = new Node<int>(50);
            tree.Root.LeftChild = new Node<int>(23);
            tree.Root.LeftChild.LeftChild = new Node<int>(20);
            tree.Root.LeftChild.RightChild = new Node<int>(45);
            tree.Root.LeftChild.RightChild.LeftChild = new Node<int>(30);
            tree.Root.LeftChild.RightChild.RightChild = new Node<int>(47);
            tree.Root.RightChild = new Node<int>(75);
            tree.Root.RightChild.LeftChild = new Node<int>(60);
            tree.Root.RightChild.RightChild = new Node<int>(90);
            tree.Root.RightChild.RightChild.LeftChild = new Node<int>(80);
            tree.Root.RightChild.RightChild.RightChild = new Node<int>(95);

            // TREE TWO
            BinarySearchTree tree2 = new BinarySearchTree();
            tree2.Root = new Node<int>(50);
            tree2.Root.LeftChild = new Node<int>(23);
            tree2.Root.LeftChild.LeftChild = new Node<int>(15);
            tree2.Root.LeftChild.RightChild = new Node<int>(45);
            tree2.Root.LeftChild.RightChild.LeftChild = new Node<int>(35);
            tree2.Root.LeftChild.RightChild.RightChild = new Node<int>(47);
            tree2.Root.RightChild = new Node<int>(70);
            tree2.Root.RightChild.LeftChild = new Node<int>(60);
            tree2.Root.RightChild.RightChild = new Node<int>(85);
            tree2.Root.RightChild.RightChild.LeftChild = new Node<int>(80);
            tree2.Root.RightChild.RightChild.RightChild = new Node<int>(90);

            List<int> duplicates = TreeIntersections(tree, tree2);
            PrintList(duplicates);
        }

        /// <summary>
        /// Returns a list of integers of all of the matching nodes from two binary search trees
        /// </summary>
        /// <param name="tree1">First binary tree to evaluate</param>
        /// <param name="tree2">Second binary tree to evaluate</param>
        /// <returns>List of matching values</returns>
        public static List<int> TreeIntersections(BinarySearchTree tree1, BinarySearchTree tree2)
        {
            if (tree1.Root == null || tree2.Root == null)
                throw new Exception("One of the trees contains no values");

            List<int> values = new List<int>();
            List<int> values2 = new List<int>();
            List<int> duplicates = new List<int>();

            values = tree1.PreOrder(tree1.Root);
            values2 = tree2.PreOrder(tree2.Root);

            for (int i = 0; i < values.Count; i++)
            {
                if (values[i] == values2[i])
                    duplicates.Add(values[i]);
            }
            return duplicates;
        }

        /// <summary>
        /// Prints out all the values of a list of integers
        /// </summary>
        /// <param name="list">The list to iterate through</param>
        public static void PrintList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + ", ");
            }
        }
    }
}