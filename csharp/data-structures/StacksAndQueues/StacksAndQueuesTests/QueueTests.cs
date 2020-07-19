using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues;
using Xunit;

namespace StacksAndQueuesTests
{
    public class QueueTests
    {

        // Test Enqueue()
        [Fact]
        public void CanEnqueueIntoQueue()
        {
            // arrange 
            Queue queue = new Queue();

            // act
            queue.Enqueue("Courtney");

            // assert
            Assert.Equal("Courtney", queue.Front.Value);
        }

        // Test Enqueue()
        [Fact]
        public void CanEnqueueMultipleNodesToQueue()
        {
            // arrange
            Queue queue = new Queue();

            // act
            queue.Enqueue("Dog");
            queue.Enqueue("Cat");
            queue.Enqueue("Mouse");

            string front = queue.Front.Value;
            string middle = queue.Front.Next.Value;
            string rear = queue.Rear.Value;

            bool fullQueue = false;
            if (front == "Dog" && middle == "Cat" && rear == "Mouse")
                fullQueue = true;

            // assert
            Assert.True(fullQueue);
        }

        // Test Dequeue() 
        [Fact]
        public void CanDequeueAndReturnTheFrontValue()
        {
            // arrange
            Queue queue = new Queue();

            // act
            queue.Enqueue("Dog");
            queue.Enqueue("Cat");
            queue.Enqueue("Mouse");

            string frontValue = queue.Dequeue();

            // assert
            Assert.Equal("Dog", frontValue);
        }

        // Test IsEmpty(), Enqueue() & Dequeue() 
        [Fact]
        public void CanEmptyAQueueUsingMulitpleDequeue()
        {
            // arrange
            Queue queue = new Queue();

            // act
            queue.Enqueue("Dog");
            queue.Enqueue("Cat");
            queue.Enqueue("Mouse");

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            bool isEmpty = queue.IsEmpty();

            // assert
            Assert.True(isEmpty);
        }

        // Test Peek() 
        [Fact]
        public void CanReturnTheFrontValueWithoutRemovingIt()
        {
            // arrange
            Queue queue = new Queue();

            // act
            queue.Enqueue("Dog");
            queue.Enqueue("Cat");
            queue.Enqueue("Mouse");

            string frontValue = queue.Peek();

            // assert
            Assert.Equal("Dog", frontValue);
        }

        // Test queue instantiation
        [Fact]
        public void CanInstantiateAnEmptyQueue()
        {
            // arrange
            Queue queue = new Queue();

            // act
            bool isEmpty = queue.IsEmpty();

            // assert
            Assert.True(isEmpty);
        }

        // Test Throw Exception on Peek()
        [Fact]
        public void CanRaiseExceptionWhenPeekOnEmptyQueue()
        {
            // arrange
            Queue queue = new Queue();

            // act
            Action act = () => queue.Peek();
            var exception = Assert.Throws<NullReferenceException>(act);

            // assert
            Assert.Equal("Queue is empty", exception.Message);
        }

        // Test Throw Exception on Dequeue()
        [Fact]
        public void CanRaiseExceptionWhenDequeueOnEmptyQueue()
        {
            // arrange
            Queue queue = new Queue();

            // act
            Action act = () => queue.Dequeue();
            var exception = Assert.Throws<NullReferenceException>(act);

            // assert
            Assert.Equal("Queue is empty", exception.Message);
        }
    }
}
