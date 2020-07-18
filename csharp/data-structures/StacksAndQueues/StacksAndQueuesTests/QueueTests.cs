using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues;
using Xunit;

namespace StacksAndQueuesTests
{
    public class QueueTests
    {

        [Fact]
        public void CanEqueueIntoQueue()
        {
            // arrange 
            Queue queue = new Queue();

            // act
            queue.Enqueue("Courtney");
            queue.Enqueue("Andrew");

            // assert
            Assert.Equal("Courtney", queue.Front.Value);
        }
    }
}
