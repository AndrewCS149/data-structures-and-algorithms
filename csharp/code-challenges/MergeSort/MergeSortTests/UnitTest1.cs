using System;
using Xunit;
using static MergeSort.Program;

namespace MergeSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortReversedArray()
        {
            // arrange
            int[] testArray = { 5, 4, 3, 2, 1 };

            // act
            int[] result = MergeSortIt(testArray);
            int[] expected = { 1, 2, 3, 4, 5 };

            // assert
            Assert.NotNull(result);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CanSortArrayOfSameNumbers()
        {
            // arrange
            int[] testArray = { 1, 1, 1, 1, 1 };

            // act
            int[] result = MergeSortIt(testArray);

            // assert
            Assert.NotNull(result);
            Assert.Equal(testArray, result);
        }

        [Fact]
        public void CanSortWithNegativeNumbers()
        {
            // arrange
            int[] testArray = { -1, -2, -3, -4, -5 };

            // act
            int[] result = MergeSortIt(testArray);
            int[] expected = { -5, -4, -3, -2, -1 };

            // assert
            Assert.NotNull(result);
            Assert.Equal(expected, result);
        }
    }
}