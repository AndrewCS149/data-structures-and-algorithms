using LinkedListLibrary;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace LLZip
{
    public class Program
    {
        static void Main(string[] args)
        {

            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            list1.Insert(7);
            list1.Insert(5);
            list1.Insert(3);
            list1.Insert(1);

            list2.Insert(8);
            list2.Insert(6);
            list2.Insert(4);
            list2.Insert(2);

            Console.WriteLine(ZipLists(list1, list2));
        }

        /// <summary>
        /// Return a new linked list with the two passed in linked lists merged together.
        /// </summary>
        /// <param name="list1">First linked list</param>
        /// <param name="list2">Second linked list</param>
        /// <returns>Return new linked list</returns>
        public static Node ZipLists(LinkedList list1, LinkedList list2)
        {
            LinkedList zipLists = new LinkedList();

            list1.Current = list1.Head;
            list2.Current = list2.Head;

            int count = 1;
            while (list1.Current != null && list2.Current != null)
            {
                if (count % 2 == 1)
                {
                    zipLists.Append(list1.Current.Value);
                    list1.Current = list1.Current.Next;
                }
                else
                {
                    zipLists.Append(list2.Current.Value);
                    list2.Current = list2.Current.Next;
                }
                count++;
            }

            while(list1.Current != null)
            {
                zipLists.Append(list1.Current.Value);
                list1.Current = list1.Current.Next;
            }

            while (list2.Current != null)
            {
                zipLists.Append(list2.Current.Value);
                list2.Current = list2.Current.Next;
            }

            zipLists.Current = zipLists.Head;

            // if lists are empty
            if (zipLists.Current == null)
                throw new Exception("You inserted empty lists.");

            return zipLists.Current;
        }
    }
}
