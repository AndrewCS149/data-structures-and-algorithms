using System;
using System.Collections;

namespace LeftJoin
{
    public class LeftJoinHashTs
    {
        /// <summary>
        /// Accepts two hashtables and joins them together with left join logic
        /// </summary>
        /// <param name="table1">First hashtable</param>
        /// <param name="table2">Second hashtable</param>
        /// <returns>2d array of strings</returns>
        public static string[,] LeftJoinHtables(Hashtable table1, Hashtable table2)
        {
            int len = table1.Count;
            string[,] join = new string[len, 2];

            for (int i = 0; i < len; i++)
            {
            }
            return join;
        }
    }
}