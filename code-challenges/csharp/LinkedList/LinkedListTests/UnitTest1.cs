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

            string value = list.ToString();
            string expected = "42 -> 23 -> 16 -> 15 -> 8 -> 4 -> NULL";

            Assert.Equal(expected, value);
        }
    }
}
