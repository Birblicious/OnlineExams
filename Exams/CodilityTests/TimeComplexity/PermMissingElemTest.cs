using System;
using System.Collections.Generic;
using System.Text;

using Xunit;
using Codility.TimeComplexity;


namespace CodilityTests.TimeComplexity
{
    public class PermMissingElemTest
    {
        [Theory]
        [InlineData(3, new int[] { 9,5,1,6,2,7,4,8})]
        public void PermMissingElemTests (int expected, int[] A)
        {
            PermMissingElem permMissingElem = new PermMissingElem();
            int answer = permMissingElem.FindMissingElem(A);
            Assert.Equal(expected, answer);
        }
    }
}
