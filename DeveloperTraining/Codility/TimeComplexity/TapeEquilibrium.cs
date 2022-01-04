using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility.TimeComplexity
{
    public class TapeEquilibrium
    {
        public static int Solution(int[] A)
        {
            var result = int.MaxValue;
            var total = A.Sum(x => x);
            var firstPartSum = 0;
            var secondPartSum = 0;

            for (int i = 0; i < A.Length - 1; i++)
            {
                firstPartSum += A[i];
                secondPartSum = total - firstPartSum;

                var diff = Math.Abs(firstPartSum - secondPartSum);
                if (diff < result)
                {
                    result = diff;
                }

            }
            return result;
        }
    }
}
