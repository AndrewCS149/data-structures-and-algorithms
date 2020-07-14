using System;
using Xunit;
using LinkedListLibrary;

namespace LinkedListTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstatiateEmptyLinkedList()
        {
            LinkedList list = new LinkedList();
            Assert.Null(list.Head);
        }

        [Fact]
        public void CanInsertIntoLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            Assert.Equal(4, list.Head.Value);
        }

        [Fact]
        public void CanInsertMultipleNodesInLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            Assert.Equal(42, list.Head.Value);
        }

        [Fact]
        public void CanFindValueInList()
        {
            LinkedList list = new LinkedList();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            int valueToSearch = 15;
            bool exists = list.Includes(valueToSearch);

            Assert.True(exists);
        }

        [Fact]
        public void CannotFindValueInLinkedList()
        {
            LinkedList list = new LinkedList();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            int valueToSearch = 100;
            bool exists = list.Includes(valueToSearch);

            Assert.False(exists);
        }

        [Fact]
        public void CanReturnAllValuesInLinkedList()
        {
            LinkedList list = new LinkedList();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            string actual = list.ToString();
            string expected = "42 -> 23 -> 16 -> 15 -> 8 -> 4 -> NULL";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanAppendToEndOfList()
        {
            // Arrange
            LinkedList list = new LinkedList();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act
            list.Append(100);
            list.Append(150);
            string actual = list.ToString();
            string expected = "42 -> 23 -> 16 -> 15 -> 8 -> 4 -> 100 -> 150 -> NULL";

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanInsertBeforeGivenValue()
        {
            // Arrange
            LinkedList list = new LinkedList();
            int newValue = 20;
            int value = 15;

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act
            list.InsertBefore(value, newValue);
            string actual = list.ToString();
            string expected = "42 -> 23 -> 16 -> 20 -> 15 -> 8 -> 4 -> NULL";

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanInsertBeforeFirstNode()
        {
            // Arrange
            LinkedList list = new LinkedList();
            int newValue = 20;
            int value = 42;

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act
            list.InsertBefore(value, newValue);
            string actual = list.ToString();
            string expected = "20 -> 42 -> 23 -> 16 -> 15 -> 8 -> 4 -> NULL";

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanInsertAfterLastNode()
        {
            // Arrange
            LinkedList list = new LinkedList();
            int newValue = 20;
            int value = 4;

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act
            list.InsertAfter(value, newValue);
            string actual = list.ToString();
            string expected = "42 -> 23 -> 16 -> 15 -> 8 -> 4 -> 20 -> NULL";

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanInsertAfterGivenValue()
        {
            // Arrange
            LinkedList list = new LinkedList();
            int newValue = 20;
            int value = 15;

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act
            list.InsertAfter(value, newValue);
            string actual = list.ToString();
            string expected = "42 -> 23 -> 16 -> 15 -> 20 -> 8 -> 4 -> NULL";

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
