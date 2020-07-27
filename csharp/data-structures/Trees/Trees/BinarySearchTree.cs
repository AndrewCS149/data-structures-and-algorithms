using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class BinarySearchTree : BinaryTree<int>
    {
        //public Node<int> Root { get; set; }

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
        /// Adds a value into a binary search tree
        /// </summary>
        /// <param name="value">The value to insert into the tree</param>
        public void Add(int value)
        {
            Node<int> newNode = new Node<int>(value);

            if (Root == null)
                Root = newNode;
            else
                Add(newNode, Root);
        }

        /// <summary>
        /// Recursive method for the Binary Search Tree Add method
        /// </summary>
        /// <param name="newNode">The new node to insert</param>
        /// <param name="root">The current node being evaluated</param>
        private void Add(Node<int> newNode, Node<int> root)
        {
            if (newNode.Value <= root.Value)
            {
                if (root.LeftChild == null)
                    root.LeftChild = newNode;
                else
                {
                    root = root.LeftChild;
                    Add(newNode, root);
                }
            } else
            {
                if (root.RightChild == null)
                    root.RightChild = newNode;
                else
                {
                    root = root.RightChild;
                    Add(newNode, root);
                }
            }
        }

        /// <summary>
        /// Returns true or false if passed in value is in binary search tree or not
        /// </summary>
        /// <param name="value">The value to check for</param>
        /// <returns>bool</returns>
        public bool Contains(int value)
        {
            bool contains;
            if (Root == null)
                return false;
            else
                contains = Contains(value, Root);

            return contains;
        }

        /// <summary>
        /// Recursive method for Contains
        /// </summary>
        /// <param name="value">The value to search for</param>
        /// <param name="root">Current node being evaluated</param>
        /// <returns>bool</returns>
        private bool Contains(int value, Node<int> root)
        {
            bool contains = false;
            if (value == root.Value)
                contains = true;
            else if(value < root.Value)
            {
                if (root.LeftChild != null)
                { 
                    root = root.LeftChild;
                    contains = Contains(value, root);
                }
            }
            else
            {
                if (root.RightChild != null)
                {
                    root = root.RightChild;
                    contains = Contains(value, root);
                }
            }
            return contains;
        }
    }
}
