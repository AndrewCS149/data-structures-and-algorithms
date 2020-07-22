using QueuesWithStacks;
using System;
using Xunit;

namespace QueuesWithStacksTests
{
    public class UnitTest1
    {
        // Test Enqueue
        [Fact]
        public void CanEnqueueIntoPseudoQueue()
        {
            // arrange
            PseudoQueue<string> myStack = new PseudoQueue<string>();
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
            PseudoQueue<string> myStack = new PseudoQueue<string>();
            myStack.Enqueue("Dog");
            myStack.Enqueue("Cat");
            myStack.Enqueue("Mouse");
            myStack.Enqueue("Bear");

            // act
            string returnedValue = myStack.Dequeue();

            // assert
            Assert.Equal("Dog", returnedValue);
        }

        // Test Dequeue
        [Fact]
        public void CanThrowIfDequeueOnAnEmptyStack()
        {
            // arrange 
            PseudoQueue<string> myStack = new PseudoQueue<string>();

            // act
            Action act = () => myStack.Dequeue();
            var exception = Assert.Throws<NullReferenceException>(act);

            // assert
            Assert.Equal("Stack is empty", exception.Message);
        }

        // Test Enqueue
        [Fact]
        public void CanEnqueueOnToEmptyStack()
        {
            // arrange
            PseudoQueue<string> myStack = new PseudoQueue<string>();
            myStack.Enqueue("Dog");

            // act
            string returnedValue = myStack.Peek();

            // assert
            Assert.Equal("Dog", returnedValue);
        }
    }
}
