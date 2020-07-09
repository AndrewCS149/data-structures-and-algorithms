using System;
using System.Runtime.InteropServices.ComTypes;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = new int[] { 4, 8, 15, 16, 23, 42 };
            int[] nums2 = new int[] { 11, 22, 33, 44, 55, 66, 77 };
            Console.WriteLine(BinarySearch(nums, 15));
            Console.WriteLine(BinarySearch(nums2, 90));

        }

        /// <summary>
        /// Returns the passed in value's idx position within the array given array
        /// </summary>
        /// <param name="arr">Array to search through</param>
        /// <param name="search">Value to search for</param>
        /// <returns>The idx position of the search value</returns>
        static int BinarySearch(int[] arr, int search)
        {
            // get the length of the arr
            int arrLength = 0;
            foreach (int num in arr)
            {
                arrLength++;
            }

            // sort the array
            for (int i = 1; i < arrLength; i++)
            {
                if(arr[i] < arr[i-1])
                {
                    int temp = arr[i - 1];
                    arr[i - 1] = arr[i];
                    arr[i] = temp;
                }
            }

            // find the search value
            int min = 0;
            int max = arrLength - 1;
            while (min < max)
            {
                int mid = (min + max) / 2;

                if (search == arr[mid])
                    return mid;
                else if (search < arr[mid])
                    max = mid - 1;
                else
                    min = mid + 1;
            }

            // if search value does not exist
            return -1;
        }
    }
}
