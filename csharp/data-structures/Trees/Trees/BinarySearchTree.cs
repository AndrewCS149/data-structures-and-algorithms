using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class BinarySearchTree
    {
        public Node<int> Root { get; set; }

        /// <summary>
        /// Constructor for empty binary search tree
        /// </summary>
        public BinarySearchTree()
        {

        }

        /// <summary>
        /// Constructor for binary search tree with root node
        /// </summary>
        /// <param name="value">The root node's value</param>
        public BinarySearchTree(int value)
        {
            Node<int> root = new Node<int>(value);
            Root = root;
        }

        public void Insert(int value)
        {
            if(value <= Root.Value)
            {

            }
        }
    }
}
