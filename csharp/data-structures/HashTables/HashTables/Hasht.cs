using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace HashTables
{
    public class Hasht
    {
        public LinkedList<Node>[] Map { get; set; }

        public Hasht(int size)
        {
            Map = new LinkedList<Node>[size];
        }

        /// <summary>
        /// Computes a hash based on the ASCII values of the key characters
        /// </summary>
        /// <param name="key">The given key to hash</param>
        /// <returns>Index of the array placement</returns>
        private int GetHash(string key)
        {
            // determine our algo for our hash
            int total = 0;
            for (int i = 0; i < key.Length; i++)
            {
                total += key[i];
            }

            int primeValue = total * 599;
            return primeValue % Map.Length;
        }

        /// <summary>
        /// Adds a node to the END? of the hashtable
        /// </summary>
        /// <param name="key">Key of the added node</param>
        /// <param name="value">Values of the added node</param>
        public void Add(string key, string value)
        {
            int idx = GetHash(key);
            Node node = new Node(key, value);
            LinkedListNode<Node> newNode = new LinkedListNode<Node>(node);
            if (Map[idx] is null)
            {
                Map[idx] = new LinkedList<Node>();
            }
            Map[idx].AddLast(newNode);
        }

        /// <summary>
        /// Checks to see if a key exists within the hashtable
        /// </summary>
        /// <param name="key">The key to search for</param>
        /// <returns>A boolean tellings if the key was found or not</returns>
        public bool Contains(string key)
        {
            int idx = GetHash(key);
            var loc = Map[idx];
            if (!(loc is null))
            {
                var current = Map[idx].First;
                while (current != null)
                {
                    if (current.Value.Key == key)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Returns the value at a specified key
        /// </summary>
        /// <param name="key">The key to search for</param>
        /// <returns>The value of the key</returns>
        public string GetValue(string key)
        {
            int idx = GetHash(key);
            var loc = Map[idx];
            if (loc is null)
            {
                return null;
            }
            return loc.First.Value.Value;
        }

        /// <summary>
        /// Counts all the keys inside of the hashtable
        /// </summary>
        /// <returns>The number of keys</returns>
        public int Count()
        {
            int count = 0;
            foreach (var key in Map) count++;
            return count;
        }
    }
}