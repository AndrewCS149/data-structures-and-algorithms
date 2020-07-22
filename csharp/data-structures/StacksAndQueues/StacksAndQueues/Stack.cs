using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Stack<T> : IEnumerable<T>
    {
        public Node<T> Top { get; set; }

        /// <summary>
        /// Pushes a new node to the top of the stack
        /// </summary>
        /// <param name="value">Value of the node to push</param>
        public void Push(T val)
        {
            Node<T> node = new Node<T>(val);
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Removes the top node and returns its value
        /// </summary>
        /// <returns>Returns the top nodes string value</returns>
        public T Pop()
        {
            if (Top.Value == null)
                throw new NullReferenceException("Stack is empty");
            Node<T> temp = Top;
            Top = Top.Next;
            return temp.Value;
        }

        /// <summary>
        /// Removes node from top of stack
        /// </summary>
        /// <returns>Returns top node's string value</returns>
        public T Peek()
        {
            if (Top.Value == null)
                throw new NullReferenceException("Stack is empty");
            return Top.Value;
        } 

        /// <summary>
        /// Check if the stack is empty or not
        /// </summary>
        /// <returns>Returns true if empty, false if not</returns>
        public bool IsEmpty()
        {
            return Top == null ? true : false;
        }



        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
