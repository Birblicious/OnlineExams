using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Arrays
{
    public class CyclicRotation
    {
        public int[] RotateArray(int[] Input, int Rotate) {
           

            int[] overflowArray = new int[Rotate];
            int length = Input.Length - 1;

            if (Rotate == 0 || Rotate == length + 1 || length == 0 || length == -1)
            {
                return Input;
            }

            if (Rotate > length + 1) {
                Rotate %= length + 1;
            }

            for (int i = 0; i < Rotate; i++) {
                overflowArray[i] = Input[length - Rotate + i + 1];
            }

            for (int i = length; i > Rotate - 1; i--) {
                Input[i] = Input[i - Rotate];
                
            }

            for (int i = 0; i < Rotate; i++) {
                Input[i] = overflowArray[i];
            }

            return Input;
        }
    }
}
