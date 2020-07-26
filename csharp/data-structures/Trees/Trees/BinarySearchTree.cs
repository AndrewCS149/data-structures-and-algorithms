using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class BinarySearchTree : BinaryTree<int>
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

        /// <summary>
        /// Inserts a value into a binary search tree
        /// </summary>
        /// <param name="value">The value to insert into the tree</param>
        public void Insert(int value)
        {
            Node<int> newNode = new Node<int>(value);

            if (Root == null)
                Root = newNode;
            else
                Insert(newNode, Root);
        }

        /// <summary>
        /// Recursive method for the Binary Search Tree Insert method
        /// </summary>
        /// <param name="newNode">The new node to insert</param>
        /// <param name="root">The current node being evaluated</param>
        private void Insert(Node<int> newNode, Node<int> root)
        {
            if (newNode.Value <= root.Value)
            {
                if (root.LeftChild == null)
                    root.LeftChild = newNode;
                else
                {
                    root = root.LeftChild;
                    Insert(newNode, root);
                }
            } else
            {
                if (root.RightChild == null)
                    root.RightChild = newNode;
                else
                {
                    root = root.RightChild;
                    Insert(newNode, root);
                }
            }
        }
    }
}
