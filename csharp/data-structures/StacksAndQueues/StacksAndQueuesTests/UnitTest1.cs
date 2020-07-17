using System;
using Xunit;
using StacksAndQueues;

namespace StacksAndQueusTests
{
    public class UnitTest1
    {
        // Test Push()
        [Fact]
        public void CanPushOnStack()
        {
            // arrange
            Stack stack = new Stack();

            // act
            stack.Push("candy cane");

            // assert
            Assert.Equal("candy cane", stack.Top.Value);
        }

        // Test Peek()
        [Fact]
        public void CanPeekTopAndReturnItsValue()
        {
            // arrange
            Stack stack = new Stack();
            stack.Push("Dog");

            // act
            string actual = stack.Peek();

            // assert
            Assert.Equal("Dog", actual);
        }

        // Test IsEmpty()
        [Fact]
        public void CanReturnTrueIfStackIsEmpty()
        {
            // arrange
            Stack stack = new Stack();

            // act
            bool emptyStack = stack.IsEmpty();

            // assert
            Assert.True(emptyStack);
        }
    }
}