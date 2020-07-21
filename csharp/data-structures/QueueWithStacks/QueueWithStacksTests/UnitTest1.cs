using QueueWithStacks;
using System;
using System.Collections;
using Xunit;
using static QueueWithStacks.PseudoQueue;

namespace QueueWithStacksTests
{
    public class UnitTest1
    {
        // Test Enqueue()
        [Fact]
        public void CanEnqueueValueToPseudoQueue()
        {
            // arrange
            Stack stack = new Stack();
            PseudoQueue pseudoQueue = new PseudoQueue(stack);
            pseudoQueue.Enqueue(10);
            pseudoQueue.Enqueue(15);
            pseudoQueue.Enqueue(20);
            pseudoQueue.Enqueue(25);

            // act
            

            // assert
        }
    }
}
