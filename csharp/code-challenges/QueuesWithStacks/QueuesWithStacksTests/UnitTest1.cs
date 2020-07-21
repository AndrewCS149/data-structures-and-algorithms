using QueuesWithStacks;
using System;
using Xunit;
using static QueuesWithStacks.PseudoQueue;

namespace QueuesWithStacksTests
{
    public class UnitTest1
    {
        // Test Enqueue
        [Fact]
        public void CanEnqueueIntoPseudoQueue()
        {
            // arrange
            PseudoQueue myStack = new PseudoQueue();
            myStack.Enqueue("Dog");
            myStack.Enqueue("Cat");
            myStack.Enqueue("Mouse");
            myStack.Enqueue("Bear");

            // act
            string returnedValue = myStack.Peek();

            // assert
            Assert.Equal("Dog", returnedValue);
        }

        // Test Dequeue
        [Fact]
        public void CanDequeueFromPseudoQueue()
        {
            // arrange
            PseudoQueue myStack = new PseudoQueue();
            myStack.Enqueue("Dog");
            myStack.Enqueue("Cat");
            myStack.Enqueue("Mouse");
            myStack.Enqueue("Bear");

            // act
            string returnedValue = myStack.Dequeue();

            // assert
            Assert.Equal("Bear", returnedValue);
        }
    }
}
