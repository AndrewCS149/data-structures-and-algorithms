using System;
using Xunit;
using Trees;
using System.Collections.Generic;

namespace TreesTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateEmptyTree()
        {
            // arrange & act
            BinaryTree<int> tree = new BinaryTree<int>();

            // assert
            Assert.Null(tree.Root);
        }

        [Fact]
        public void CanInstantiateTreeWithSingleRoot()
        {
            // arrange & act
            BinaryTree<int> tree = new BinaryTree<int>(50);

            // assert
            Assert.NotNull(tree.Root);
            Assert.Equal(50, tree.Root.Value);
            Assert.IsType<Node<int>>(tree.Root);
        }

        [Fact]
        public void CanAddLeftAndRightToRoot()
        {
            // arrange & act
            BinaryTree<char> tree = new BinaryTree<char>('a');

            Node<char> leftChild = new Node<char>('b');
            Node<char> rightChild = new Node<char>('c');

            tree.Root.LeftChild = leftChild;
            tree.Root.RightChild = rightChild;

            // assert
            Assert.NotNull(tree.Root.LeftChild);
            Assert.NotNull(tree.Root.RightChild);
            Assert.Equal('b', tree.Root.LeftChild.Value);
            Assert.Equal('c', tree.Root.RightChild.Value);
        }

        [Fact]
        public void CanReturnPreOrderTraversal()
        {
            // arrange
            BinaryTree<char> tree = new BinaryTree<char>();

            Node<char> root = new Node<char>('a');
            Node<char> b = new Node<char>('b');
            Node<char> c = new Node<char>('c');
            Node<char> d = new Node<char>('d');
            Node<char> e = new Node<char>('e');
            Node<char> f = new Node<char>('f');
            Node<char> g = new Node<char>('g');

            tree.Root = root;
            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;
            c.RightChild = g;

            List<char> order = new List<char>()
            {
                'a', 'b', 'd', 'e', 'c', 'f', 'g'
            };

            // act 
            List<char> preOrder = tree.PreOrder(tree.Root);

            // assert
            Assert.Equal(order, preOrder);
        }
    }
}
