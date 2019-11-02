using System;
using System.Collections.Generic;
using System.Text;
using Codility.Arrays;
using Xunit;
namespace CodilityTests.Arrays
{
    public class OddOccurencesInArrayTests
    {

        [Theory]
        [InlineData(3, new int[] { 1, 2, 3, 2, 1 })]
        public void OddOccurencesInArrayTest(int expected, int[] Input) {
            OddOccurencesInArray oddOccurencesInArray = new OddOccurencesInArray();
            int oddOccurence = oddOccurencesInArray.FindOddElement(Input);
            Assert.Equal(expected, oddOccurence);
        }
    }
}
