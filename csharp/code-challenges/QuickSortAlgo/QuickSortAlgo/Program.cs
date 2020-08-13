using System;
using System.Collections.Concurrent;

namespace QuickSortAlgo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] testArr = { 8, 4, 23, 42, 16, 15 };
            int[] sortedArr = QuickSort(testArr, 0, testArr.Length - 1);
            PrintArr(sortedArr);
        }

        /// <summary>
        /// Sorts an array from least to greatest using a quick sort approach
        /// </summary>
        /// <param name="arr">The array to sort</param>
        /// <param name="left">Left bounds of the array</param>
        /// <param name="right">Right bounds of the array</param>
        /// <returns></returns>
        public static int[] QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pos = Partition(arr, left, right);

                arr = QuickSort(arr, left, pos - 1);
                arr = QuickSort(arr, pos + 1, right);
            }

            return arr;
        }

        /// <summary>
        /// Partitions the array
        /// </summary>
        /// <param name="arr">The array to partition</param>
        /// <param name="left">The left bounds of the array</param>
        /// <param name="right">The right bounds of the array</param>
        /// <returns></returns>
        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }
            }

            Swap(arr, right, low + 1);

            return low + 1;
        }

        /// <summary>
        /// Helper method to swap array positions
        /// </summary>
        /// <param name="arr">Array to swap on</param>
        /// <param name="i">First idx position to swap</param>
        /// <param name="low">Second idx position to swap</param>
        public static void Swap(int[] arr, int i, int low)
        {
            int temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }

        /// <summary>
        /// Prints out all items in an array
        /// </summary>
        /// <param name="arr">Array to iterate through</param>
        public static void PrintArr(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write($"{num}, ");
            }
        }
    }
}