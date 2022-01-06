using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.CountingElements
{
    public class MaxCounters
    {
        public static int[] Solution(int N, int[] A)
        {
            var counterArr = new int[N];
            int max = 0;
            int min = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (1 <= A[i] && A[i] <= N)
                {
                    if (counterArr[A[i] - 1] < min + 1)
                    {
                        counterArr[A[i] - 1] = min + 1;
                    }
                    else
                    {
                        counterArr[A[i] - 1]++;
                    }

                    if (counterArr[A[i] - 1] > max)
                        max = counterArr[A[i] - 1];
                }
                else
                {
                    min = max;
                }
            }

            for (int i = 0; i < counterArr.Length; i++)
            {
                if (counterArr[i] < min)
                    counterArr[i] = min;
            }

            return counterArr;

        }
    }
}
