using System;
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
    }
}
