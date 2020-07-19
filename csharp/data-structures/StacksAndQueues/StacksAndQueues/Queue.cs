﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue()
        {
            Rear = Front;
        }

        /// <summary>
        /// Enqueue a Node into a queue
        /// </summary>
        /// <param name="val">String value to enqueue</param>
        public void Enqueue(string val)
        {
            Node node = new Node(val);

            if (Front == null)
            { 
                Front = node;
                Rear = node;
            }
            else
            {
                Rear.Next = node;
                Rear = node;
            }
        }

        /// <summary>
        /// Dequeue the front node from the queue
        /// </summary>
        /// <returns>Returns the front nodes value</returns>
        public string Dequeue()
        {
            // if stack is empty
            if (Front == null)
                throw new NullReferenceException("Queue is empty");

            Node temp = Front;
            Front = Front.Next;

            return temp.Value;
        }

        /// <summary>
        /// Returns the front node's value without removing it
        /// </summary>
        /// <returns>The front nodes value</returns>
        public string Peek()
        {
            // if stack is empty
            if (Front == null)
                throw new NullReferenceException("Queue is empty");

            return Front.Value;
        }

        /// <summary>
        /// Checks whether the queue is empty or not
        /// </summary>
        /// <returns>Returns true if empty, false if not</returns>
        public bool IsEmpty()
        {
            return Front == null ? true : false;
        }
    }
}
