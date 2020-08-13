using System;
using Xunit;
using static QuickSortAlgo.Program;

namespace QuickSortAlgoTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortAnArray()
        {
            // arrange
            int[] array = { 4, 2, 19, 99, 4, 2, 0 };
            int[] expected = { 0, 2, 2, 4, 4, 19, 99 };

            // act
            int[] sortedArray = QuickSort(array, 0, array.Length - 1);

            // assert
            Assert.NotNull(sortedArray);
            Assert.Equal(expected, sortedArray);
        }

        [Fact]
        public void CanSortArrayWithSameNumbers()
        {
            // arrange
            int[] array = { 5, 5, 5, 5, 5, 5 };

            // act
            int[] sortedArray = QuickSort(array, 0, array.Length - 1);

            // assert
            Assert.NotNull(sortedArray);
            Assert.Equal(array, sortedArray);
        }

        [Fact]
        public void CanSortArrayWithNegativeNumbers()
        {
            // arrange
            int[] array = { -5, -3, 10, 33, -5 };
            int[] expected = { -5, -5, -3, 10, 33 };

            // act
            int[] sortedArray = QuickSort(array, 0, array.Length - 1);

            // assert
            Assert.NotNull(sortedArray);
            Assert.Equal(expected, sortedArray);
        }
    }
}