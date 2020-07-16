using System;
using Xunit;
using LinkedListLibrary;
using static LLZip.Program;


namespace LLZipTest
{
    public class UnitTest1
    {
        // Test ZipLists() method
        [Fact]
        public void CanReturnProperNode()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            list1.Insert(7);
            list1.Insert(5);
            list1.Insert(3);
            list1.Insert(1);

            list2.Insert(8);
            list2.Insert(6);
            list2.Insert(4);
            list2.Insert(2);

            // Act
            int expected = list1.Head.Value;
            int actual = ZipLists(list1, list2).Value;

            // Assert
            Assert.Equal(expected, actual);
        }

        // Test ZipLists() method
        [Fact]
        public void CanReturnProperValueWithEmptyList2()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            list1.Insert(7);
            list1.Insert(5);
            list1.Insert(3);
            list1.Insert(1);

            // Act
            int expected = list1.Head.Value;
            int actual = ZipLists(list1, list2).Value;

            // Assert
            Assert.Equal(expected, actual);
        }

        // Test ZipLists() method
        [Fact]
        public void CanReturnProperValueWithEmptyList1()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            list1.Insert(7);
            list1.Insert(5);
            list1.Insert(3);
            list1.Insert(1);

            // Act
            int expected = list1.Head.Value;
            int actual = ZipLists(list1, list2).Value;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
