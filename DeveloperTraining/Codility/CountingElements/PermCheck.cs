using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility.CountingElements
{
    public class PermCheck
    {
        public static int solution(int[] A)
        {
            A = A.OrderBy(x => x).ToArray();

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != i + 1)
                    return 0;
            }

            return 1;
        }
    }
}
