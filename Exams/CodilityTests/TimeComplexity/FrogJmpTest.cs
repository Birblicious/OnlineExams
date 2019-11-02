using System;
using System.Collections.Generic;
using System.Text;

using Xunit;
using Codility.TimeComplexity;

namespace CodilityTests.TimeComplexity
{
    public class FrogJmpTest
    {
        [Theory]
        [InlineData(190, 10, 200, 1)]
        [InlineData(0, 99, 99, 1)]
        public void FrogJmpTests(int expected, int X, int Y, int D)
        {
            FrogJmp frogJmp = new FrogJmp();
            int answer = frogJmp.FindFroggyJumps(X, Y, D);
            Assert.Equal(expected, answer);
        }
    }
}
