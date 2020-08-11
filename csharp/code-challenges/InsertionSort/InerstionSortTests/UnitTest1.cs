using System;
using Xunit;
using static InsertionSort.Program;

namespace InerstionSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnSortedArray()
        {
            // arrange
            int[] testArr = new int[] { 8, 4, 23, 42, 16, 15 };

            // act
            int[] result = InsertionSortMethod(testArr);
            int[] expected = new int[] { 4, 8, 15, 16, 23, 42 };

            // assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CanSortReversedArray()
        {
            // arrange
            int[] testArr = new int[] { 20, 18, 12, 8, 5, -2 };

            // act
            int[] result = InsertionSortMethod(testArr);
            int[] expected = new int[] { -2, 5, 8, 12, 18, 20 };

            // assert
            Assert.Equal(expected, result);
        }
    }
}