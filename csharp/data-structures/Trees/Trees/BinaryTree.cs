using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;

namespace Trees
{
    public class BinaryTree<T>
    {
        public Node<T> Root { get; set; }

        /// <summary>
        /// Constructor for empty binary tree
        /// </summary>
        public BinaryTree()
        {

        }

        /// <summary>
        /// Constructor for binary tree with root node
        /// </summary>
        /// <param name="value">The root node's value</param>
        public BinaryTree(T value)
        {
            Node<T> root = new Node<T>(value);
            Root = root;
        }

        /// <summary>
        /// PreOrder traversal for a binary tree
        /// </summary>
        /// <param name="root">The root note of the binary tree</param>
        /// <returns>The traversal order in a list</returns>
        public List<T> PreOrder(Node<T> root)
        {
            List<T> traversal = new List<T>();
            PreOrder(traversal, root);
            return traversal;
        }

        /// <summary>
        /// Recursive method for the PreOrder traversal method
        /// </summary>
        /// <param name="traversal">The created list of the output</param>
        /// <param name="root">The current root node being evaluated</param>
        private void PreOrder(List<T> traversal, Node<T> root)
        {
            traversal.Add(root.Value);

            if (root.LeftChild != null)
                PreOrder(traversal, root.LeftChild);

            if (root.RightChild != null)
                PreOrder(traversal, root.RightChild);
        }
    }
}
