using System;
using Xunit;
using BinarySearch;

namespace BinarySearch_xUnitTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 4, 8, 15, 16, 23, 42 }, 2)]
        [InlineData(new int[] { 11, 22, 33, 44, 55, 66, 77 },-1)]
        public static void CanBinarySearchReturnProperValue(int[] numbers, int index)
        {
            // arrange & act
            int result = Program.BinarySearch(numbers, 15);

            Assert.Equal(index, result);
        }
    }
}
