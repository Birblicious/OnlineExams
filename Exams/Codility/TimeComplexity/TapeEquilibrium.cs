using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.TimeComplexity
{
    public class TapeEquilibrium
    {
        public int FindSmallestDifference(int[] A) {
            int sum = 0;
            int smallestDifference = 0;

            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
                smallestDifference += Math.Abs(A[i]);
            }

            int firstSection = 0;
            int secondSection = sum;
            

            for (int i = 0; i < A.Length - 1; i++)
            {
                firstSection += A[i];
                secondSection = sum - firstSection;

                if ((Math.Abs(firstSection - secondSection)) < smallestDifference) {
                    smallestDifference = Math.Abs(firstSection - secondSection);
                }

            }

            return smallestDifference;
        }
    }
}
