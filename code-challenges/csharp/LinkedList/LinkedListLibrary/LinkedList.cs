using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListLibrary
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        public LinkedList()
        {
            Head = null;
            Current = Head;
        }

        /// <summary>
        /// Adds new node to the front of the linked list. O(1) time operation
        /// </summary>
        /// /// <param name="value">value to be stored in the node</param>
        public void Insert(int value)
        {
            // create the new node that needs to be added
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }

        /// <summary>
        /// Adds node to the end of a linked list
        /// </summary>
        /// <param name="value">The value to append</param>
        public void Append(int value)
        {
            Node node = new Node(value);
            Node current = Head;

            if (Head == null)
            {
                Head = node;
            }
            else
            {
                while (current != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
        }

        /// <summary>
        /// Finds a value in the linked list
        /// O(n) time efficiency 
        /// </summary>
        /// <param name="value">Value to search for</param>
        /// <returns>true if found, false if not</returns>
        public bool Includes(int value)
        {
            Current = Head;

            // while loop to traverse the linked list and compare values
            while (Current != null)
            {
                if (Current.Value == value)
                    return true;

                Current = Current.Next;
            }
            return false;
        }

        /// <summary>
        /// Overriding current behavior of toString method to output all values in the linked list as a string
        /// </summary>
        /// <returns>a string containing all the values of the linked list</returns>
        public override string ToString()
        {
            Current = Head;

            StringBuilder sb = new StringBuilder();

            // start constructing sb
            while (Current != null)
            {
                sb.Append($"{Current.Value} -> ");
                Current = Current.Next;
            }

            sb.Append("NULL");

            return sb.ToString();
        }
    }
}
