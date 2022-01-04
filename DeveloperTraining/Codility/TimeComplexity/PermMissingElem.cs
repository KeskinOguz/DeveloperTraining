using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility.TimeComplexity
{
    public class PermMissingElem
    {
        public static int Solution(int[] A)
        {
            A = A.OrderBy(x => x).ToArray();

            for (int i = 0; i < A.Length; i++)
            {
                if (i + 1 != A[i])
                    return i + 1;
            }

            return A.Length + 1;
        }
    }
}
