using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.CountingElements
{
    public class FrogRiverOne
    {
        public static int Solution(int X, int[] A)
        {
            var countArr = new int[X + 1];

            int j = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= X && countArr[A[i]] < 1)
                {
                    countArr[A[i]] += 1;
                    j++;
                }

                if (j == X)
                    return i;

            }

            return -1;
        }
    }
}
