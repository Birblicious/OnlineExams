using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Codility.Arrays;

namespace CodilityTests.Arrays
{
    public class CyclicRotationTests
    {
        [Theory]
        [InlineData (new int[3] {3,1,2}, new int[3] {1,2,3 }, 1)]
        [InlineData (new int[9] { 3, 1, 2, 5, 6, 8, 7, 0, 5 }, new int[9] { 8, 7, 0, 5, 3, 1, 2, 5, 6 }, 5)]
        public void RotateMyArray(int[] expected, int[] input, int rotate) {
            CyclicRotation cyclicRotation = new CyclicRotation();
            int[] output = new int[input.Length];
            output = cyclicRotation.RotateArray(input, rotate);
            Assert.Equal(expected, output);
        }
    }
}
