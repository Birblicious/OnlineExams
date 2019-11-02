using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Arrays
{
    public class OddOccurencesInArray
    {
        public int FindOddElement(int[] Input) {

            var dictionary = new Dictionary<int, int>();

            foreach (int integer in Input) {
                if (!dictionary.ContainsKey(integer))
                {
                    dictionary.Add(integer, 1);
                }
                else {
                    dictionary[integer] = dictionary[integer] + 1;
                }
            }

            foreach (KeyValuePair<int, int> entry in dictionary) {
                if (entry.Value % 2 != 0) {
                    return entry.Key;
                }
            }

            return 0;
        }
    }
}
