using System;
using System.Collections;

namespace QueueWithStacks
{
    public class PseudoQueue
    {
        public Stack Stack { get; set; }

        public PseudoQueue(Stack stack)
        {
            Stack = stack;
        }

        /// <summary>
        /// Enqueues a value onto the PseudoQueue
        /// </summary>
        /// <param name="val">The int value to enqueue</param>
        public void Enqueue(int val)
        {
            Stack.Push(val);

        }

        /// <summary>
        /// Dequeues the front value from the PseudoQueue
        /// </summary>
        /// <returns>Returns the dequeued int value</returns>
        public int Dequeue()
        {

            return -1;
        }
    }
}
