using System;

namespace InsertionSort
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] testArr1 = new int[] { 8, 4, 23, 42, 16, 15 };
            int[] testArr1Sort = InsertionSortMethod(testArr1);
            PrintArr(testArr1Sort);
        }

        /// <summary>
        /// Prints out the elements of an array
        /// </summary>
        /// <param name="arr">Array to print</param>
        private static void PrintArr(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item}, ");
            }
        }

        /// <summary>
        /// Uses insertion sort to sort the array from least to greatest
        /// </summary>
        /// <param name="arr">The array of ints to sort</param>
        /// <returns>The sorted array of ints</returns>
        public static int[] InsertionSortMethod(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while (j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = temp;
            }

            return arr;
        }
    }
}