using System;

namespace ArrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArr = { 1, 2, 4, 5 };
            int testVal = 10;
            Console.WriteLine(insertShiftArray(testArr, testVal));

        }

        public static int[] insertShiftArray(int[] array, int value)
        {
            int length = 0;
            int midIdx;

            foreach (int num in array)
            {
                length++;
            }

            midIdx = length / 2;
            int[] newArr = new int[length + 1];

            for (int i = 0; i <= length; i++)
            {
                if (i < midIdx)
                {
                    newArr[i] = array[i];
                }
                else if (midIdx == i)
                {
                    newArr[i] = value;
                } else
                {
                    newArr[i] = array[i - 1];
                }
            }

            foreach (int item in newArr)
            {
                Console.Write(item + ", ");
            }

            return newArr;

        }


    }
}
