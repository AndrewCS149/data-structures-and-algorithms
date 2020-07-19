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
    }
}
