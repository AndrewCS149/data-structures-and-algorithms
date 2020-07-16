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
        /// Return the node's value that is kth nodes from the end of the list.
        /// </summary>
        /// <param name="value">The kth element.</param>
        /// <returns>Returns node.</returns>
        public int KthFromEnd(int k)
        {
            if (k < 0)
                throw new Exception("K cannot be less than zero");

            Node current = Head;
            int listLen = 0;

            // get length of list
            while(current != null)
            {
                current = current.Next;
                listLen++;
            }

            if (k >= listLen)
                throw new Exception("K cannot be greater than or equal to the list length");

            int target = listLen - k;
            current = Head;

            // find kth element from end of list
            int count = 1;
            while(current != null)
            {
                if (count == target)
                {
                    return current.Value;
                }
                count++;
                current = current.Next;
            }
            throw new Exception("That value does not exists");
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
            Node newNode = new Node(value);
            Node current = Head;

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        /// <summary>
        /// Insert the passed in 'value' directly before the passed in 'newValue'
        /// </summary>
        /// <param name="value">Value to insert</param>
        /// <param name="newValue">Value to insert before</param>
        public void InsertBefore(int value, int newValue)
        {
            Node newNode = new Node(newValue);
            Node current = Head;

            if (Head ==  null)
            {
                Head = newNode;
                return;
            }
            else if (Head.Value == value)
            {
                Insert(newValue);
                return;
            }
            else
            {
                while (current.Next != null)
                {
                    if (current.Next.Value == value)
                    {
                        Node temp = current.Next;
                        current.Next = newNode;
                        newNode.Next = temp;
                        return;
                    }
                    current = current.Next;
                }
            }
            throw new Exception("Sorry. That value does not exist within the current list.");
        }

        /// <summary>
        /// Insert the passed in 'value' directly after the passed in 'newValue'
        /// </summary>
        /// <param name="value">Value to insert</param>
        /// <param name="newValue">Value to insert after</param>
        public void InsertAfter(int value, int newValue)
        {
            Node newNode = new Node(newValue);
            Node current = Head;

            if(Head == null)
            {
                Head = newNode;
                return;
            }
            else
            {
                while (current != null)
                {
                    if (current.Value == value)
                    {
                        newNode.Next = current.Next;
                        current.Next = newNode;
                        return;
                    }
                    current = current.Next;
                }
            }
            throw new Exception("Sorry. That value does not exist within the current list.");
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

                public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        public int Count()
        {
            return count;
        }

        // magic, dont touch
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
