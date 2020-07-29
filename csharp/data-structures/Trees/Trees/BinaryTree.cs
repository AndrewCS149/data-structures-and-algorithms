using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
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

        /// <summary>
        /// InOrder traversal for a binary tree
        /// </summary>
        /// <param name="root">The root note of the binary tree</param>
        /// <returns>The traversal order in a list</returns>
        public List<T> InOrder(Node<T> root)
        {
            List<T> traversal = new List<T>();
            InOrder(traversal, root);
            return traversal;
        }

        /// <summary>
        /// Recursive method for the InOrder traversal method
        /// </summary>
        /// <param name="traversal">The created list of the output</param>
        /// <param name="root">The current root node being evaluated</param>
        private void InOrder(List<T> traversal, Node<T> root)
        {
            if (root.LeftChild != null)
                InOrder(traversal, root.LeftChild);

            traversal.Add(root.Value);

            if (root.RightChild != null)
                InOrder(traversal, root.RightChild);
        }

        /// <summary>
        /// PostOrder traversal for a binary tree
        /// </summary>
        /// <param name="root">The root note of the binary tree</param>
        /// <returns>The traversal order in a list</returns>
        public List<T> PostOrder(Node<T> root)
        {
            List<T> traversal = new List<T>();
            PostOrder(traversal, root);
            return traversal;
        }

        /// <summary>
        /// Recursive method for the PostOrder traversal method
        /// </summary>
        /// <param name="traversal">The created list of the output</param>
        /// <param name="root">The current root node being evaluated</param>
        private void PostOrder(List<T> traversal, Node<T> root)
        {
            if (root.LeftChild != null)
                PostOrder(traversal, root.LeftChild);

            if (root.RightChild != null)
                PostOrder(traversal, root.RightChild);

            traversal.Add(root.Value);
        }

        /// <summary>
        /// Returns the largest value in a integer Binary Tree
        /// </summary>
        /// <param name="root">The root node</param>
        /// <returns>The largest value</returns>
        public T FindMaxValue(Node<T> root)
        {
            if (root.Value.GetType() != typeof(int))
                throw new Exception("Cannot find max value of non integer types");

            List<T> orderedList = InOrder(root);
            return orderedList[orderedList.Count - 1];
        }
    }
}
