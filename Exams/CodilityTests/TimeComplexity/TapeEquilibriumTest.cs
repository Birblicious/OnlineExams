using System;
using System.Collections.Generic;
using System.Text;

using Xunit;
using Codility.TimeComplexity;

namespace CodilityTests.TimeComplexity
{
    public class TapeEquilibriumTest
    {
        [Theory]
        [InlineData(1, new int[] { 3, 1, 2, 4, 3 })]
        [InlineData(2000, new int[]{-1000, 1000})]
        [InlineData(3, new int[] { -1, -2, -3, -4, -5})]
        public void TapeEquilibriumTests(int expected, int[] A)
        {
            TapeEquilibrium tapeEquilibrium = new TapeEquilibrium();
            int answer = tapeEquilibrium.FindSmallestDifference(A);
            Assert.Equal(expected, answer);
        }
    }
}
