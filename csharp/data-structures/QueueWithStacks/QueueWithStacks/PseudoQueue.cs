using System;
using System.Collections;
using System.Xml;

namespace QueueWithStacks
{
    public class PseudoQueue
    {
        public Stack Stack { get; set; }
        public Node Top { get; set; }

        public PseudoQueue()
        {
            Stack = new Stack();
        }

        /// <summary>
        /// Enqueues a value onto the PseudoQueue
        /// </summary>
        /// <param name="val">The int value to enqueue</param>
        public void Enqueue(int val)
        {
            //PseudoQueue flipped = new PseudoQueue(Stack);

            
            Stack.Push(val);
        }

        /// <summary>
        /// Dequeues the front value from the PseudoQueue
        /// </summary>
        /// <returns>Returns the dequeued int value</returns>
        public int Dequeue()
        {
            Stack flipped = new Stack();
            
            while(flipped)


            return -1;
        }
    }
}
