using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;

namespace MergeSort
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = { 5, 4, 3, 2, 1 };
            Console.WriteLine("Original Array:");
            PrintArray(arr);

            arr = MergeSortIt(arr);
            Console.WriteLine("Sorted Array");
            PrintArray(arr);
        }

        private static int[] MergeSortIt(int[] arr)
        {
            // base case
            if (arr.Length <= 1)
                return arr;

            int mid = arr.Length / 2;
            int[] left = new int[mid];
            int[] right;

            if (arr.Length % 2 == 0)
            {
                right = new int[mid];
            }
            else
            {
                right = new int[mid + 1];
            }

            for (int i = 0; i < mid; i++)
            {
                left[i] = arr[i];
            }
            for (int j = 0; j < right.Length; j++)
            {
                right[j] = arr[mid + j];
            }

            int[] result = new int[arr.Length];
            left = MergeSortIt(left);
            right = MergeSortIt(right);

            result = Merge(left, right);
            return result;
        }

        private static int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];

            // pointers
            int rightP = 0;
            int leftP = 0;
            int resultsP = 0;

            while (leftP < left.Length || rightP < right.Length)
            {
                if (leftP < left.Length && rightP < right.Length)
                {
                    if (left[leftP] < right[rightP])
                    {
                        result[resultsP] = left[leftP];
                        leftP++;
                        resultsP++;
                    }
                    else
                    {
                        result[resultsP] = right[rightP];
                        rightP++;
                        resultsP++;
                    }
                }
                else if (leftP < left.Length)
                {
                    result[resultsP] = left[leftP];
                    resultsP++;
                    leftP++;
                }
                else if (rightP < right.Length)
                {
                    result[resultsP] = right[rightP];
                    resultsP++;
                    rightP++;
                }
            }
            return result;
        }

        private static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write($"{num}, ");
            }
        }
    }
}