using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Iterations
{
    public class BinaryGap
    {
        public int GetLongestZeroTrail(int Input)
        {

            int longestZeroTrail = 0;
            int tempZeroTrail = 0;
            bool trailHasStarted = false;

            while (Input != 0) //Exit Condition
            {
                int remainder = Input % 2; //Get remainder

                if (remainder == 1) //Start trail & End trail
                {
                    if (trailHasStarted)
                    {
                        if (longestZeroTrail < tempZeroTrail) //If found longer than before save it
                        {
                            longestZeroTrail = tempZeroTrail;
                            tempZeroTrail = 0;
                        }
                        else
                        {
                            tempZeroTrail = 0; //If not reset the trail count
                        }
                    }
                    else
                    {
                        trailHasStarted = true; //Trail started
                    }

                }
                else
                {
                    if (trailHasStarted)
                    {
                        tempZeroTrail++;
                    }
                    else
                    {
                        tempZeroTrail = 0;
                    }
                }

                Input = Input / 2;
            }


            return longestZeroTrail;
        }
    }
}
