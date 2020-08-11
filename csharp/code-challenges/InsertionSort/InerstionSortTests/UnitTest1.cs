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
    }
}