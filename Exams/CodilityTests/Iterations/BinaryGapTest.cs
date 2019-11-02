using System;
using System.Collections.Generic;
using System.Text;

using Xunit;
using Codility.Iterations;

namespace CodilityTests.Iterations
{
    public class BinaryGapTest
    {
        [Fact]
        public void FirstFact() {
            Assert.Equal(5, 3 + 2);
        }

        [Theory]
        [InlineData (1, 5)]
        [InlineData(5, 1041)]
        public void BinaryGapTests(int expected, int Input) {
            BinaryGap binaryGap = new BinaryGap();
            int trailingZeros = binaryGap.GetLongestZeroTrail(Input);
            Assert.Equal(expected, trailingZeros);
        }
    }
}
