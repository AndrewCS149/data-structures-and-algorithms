﻿using StacksAndQueues;
using System;

namespace QueuesWithStacks
{
    public class PseudoQueue
    {
        public Stack MyStack { get; set; }

        public PseudoQueue()
        {
            MyStack = new Stack();
        }

        /// <summary>
        /// Looks at the top node in the stack (For testing purposes)
        /// </summary>
        /// <returns>Returns the top node's value</returns>
        public string Peek()
        {
            return MyStack.Peek();
        }

        /// <summary>
        /// Enqueues a value into the stack with a FIFO approach
        /// </summary>
        /// <param name="val">Value to enqueue</param>
        public void Enqueue(string val)
        {
            // if stack is empty
            if (MyStack.Top == null)
                MyStack.Push(val);
            else
            {
                Stack tempStack = new Stack();

                // reverse the stack and store in tempStack
                while (MyStack.Top != null)
                    tempStack.Push(MyStack.Pop());

                tempStack.Push(val);

                // re-reverse stack back to original state with added value
                while (tempStack.Top != null)
                    MyStack.Push(tempStack.Pop());
            }
        }

        /// <summary>
        /// Dequeues a node from the stack and returns it's value
        /// </summary>
        /// <returns>The bottom node's value from the stack</returns>
        public string Dequeue()
        {
            // if stack is empty
            if (MyStack.Top == null)
                throw new NullReferenceException("Stack is empty");

            return MyStack.Pop();
        }

    }
}