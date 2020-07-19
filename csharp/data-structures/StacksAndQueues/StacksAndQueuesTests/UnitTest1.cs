using System;
using Xunit;
using StacksAndQueues;
using Xunit.Sdk;

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

        // Test Push()
        [Fact]
        public void CanPushMultipleValuesOnStack()
        {
            // arrange
            Stack stack = new Stack();

            // act
            stack.Push("Andrew");
            stack.Push("Courtney");
            stack.Push("Loki");

            Node top = stack.Top;
            Node mid = stack.Top.Next;
            Node bottom = mid.Next;

            bool fullStack = false;
            if (top.Value == "Loki" && mid.Value == "Courtney" && bottom.Value == "Andrew")
                fullStack = true;

            // assert
            Assert.True(fullStack);
        }

        // Test Pop() 
        [Fact]
        public void CanEmptyStackAfterMulitplePops()
        {
            // arrange
            Stack stack = new Stack();

            // act
            stack.Push("Andrew");
            stack.Push("Courtney");
            stack.Push("Loki");

            stack.Pop();
            stack.Pop();
            stack.Pop();

            bool emptyStack = stack.IsEmpty();

            // assert
            Assert.True(emptyStack);
        }

        // Test Pop()
        [Fact]
        public void CanRemoveTopNodeAndReturnItsValue()
        {
            // arrange
            Stack stack = new Stack();

            // act
            stack.Push("Dog");
            string topValue = stack.Pop();

            // assert
            Assert.Equal("Dog", topValue);
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

        // Test Stack instantiation
        [Fact]
        public void CanInstantiateAStack()
        {
            // arrange
            Stack stack = new Stack();

            // act 
            bool emptyStack = stack.IsEmpty();

            // assert
            Assert.True(emptyStack);
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

        // Test Pop()
        [Fact]
        public void CanPopRaiseExceptionIfCalledOnAnEmptyStack()
        {
            // arrange
            Stack stack = new Stack();

            // act
            Action act = () => stack.Pop();
            var exception = Assert.Throws<NullReferenceException>(act);
            //var expected = ThrowsException
            // assert
            Assert.Equal("Object reference not set to an instance of an object.", exception.Message);
        }
    }
}