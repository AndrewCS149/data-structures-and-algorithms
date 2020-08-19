using System;
using System.Collections.Generic;
using Trees;
using Xunit;
using static TreeIntersection.Program;

namespace IntersectionTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnMatchingValues()
        {
            // arrange
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

            // act
            List<int> expected = new List<int>() { 50, 23, 45, 47, 60, 80 };
            var result = TreeIntersections(tree, tree2);

            // assert
            Assert.NotNull(result);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CanReturnNoValuesIfNoMatchingValuesFound()
        {
            // arrange
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
            tree2.Root = new Node<int>(49);
            tree2.Root.LeftChild = new Node<int>(24);
            tree2.Root.LeftChild.LeftChild = new Node<int>(15);
            tree2.Root.LeftChild.RightChild = new Node<int>(46);
            tree2.Root.LeftChild.RightChild.LeftChild = new Node<int>(35);
            tree2.Root.LeftChild.RightChild.RightChild = new Node<int>(48);
            tree2.Root.RightChild = new Node<int>(70);
            tree2.Root.RightChild.LeftChild = new Node<int>(61);
            tree2.Root.RightChild.RightChild = new Node<int>(85);
            tree2.Root.RightChild.RightChild.LeftChild = new Node<int>(81);
            tree2.Root.RightChild.RightChild.RightChild = new Node<int>(90);

            // act
            List<int> expected = new List<int>();
            var result = TreeIntersections(tree, tree2);

            // assert
            Assert.NotNull(result);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CanThrowExceptionIfEmptyTreeIsFound()
        {
            // arrange
            BinarySearchTree tree = new BinarySearchTree();
            BinarySearchTree tree2 = new BinarySearchTree();

            // act and assert
            Assert.Throws<Exception>(() => TreeIntersections(tree, tree2));
        }
    }
}