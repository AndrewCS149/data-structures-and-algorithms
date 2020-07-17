using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace StacksAndQueues
{
    public class Stack
    {
        public Node Top { get; set; }

        /// <summary>
        /// Pushes a new node to the top of the stack
        /// </summary>
        /// <param name="value">Value of the node to push</param>
        public void Push(string value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Removes node from top of stack
        /// </summary>
        /// <returns>Returns top node's string value</returns>
        public string Peek()
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
    }
}
