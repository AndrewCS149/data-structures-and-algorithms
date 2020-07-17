using System;
using Xunit;
using StacksAndQueues;


namespace StacksAndQueuesTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanPushOnStack()
        {
            Stack stack = new Stack();

            stack.Push("candy cane");

            Assert.Equal("candy cane", stack.Top.Value);
        }
    }
}
