using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Arrays
{
    public class CyclicRotation
    {
        public static int[] Solution(int[] A, int K)
        {
            var result = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                int newIndex = (i + K) % A.Length;

                result[newIndex] = A[i];
            }

            return result;
        }
    }
}
