using System;
using Xunit;

namespace AlgorithmsLibrary.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Well_Known_Array()
        {
            int[] arr = { 3, 4, 5 };
            int seed = 20;
            int[] expected = { 4, 5, 3 };
            int[] actual = arr.Randomize(seed);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_Single_Elem_Array()
        {
            int[] arr = { 100 };
            int[] expected = { 100 };
            int[] actual = arr.Randomize();
            Assert.Equal(expected, actual);
        }
    }
}
