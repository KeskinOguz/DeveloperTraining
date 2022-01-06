using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.CountingElements
{
    public class MissingInteger
    {
        public static int Solution(int[] A)
        {
            var spi = 1;

            var checkNumArr = new bool[A.Length + 1];

            for (int i = 0; i < A.Length; i++)
            {
                if ((A[i] > 0 && A[i] <= A.Length))
                    checkNumArr[A[i]] = true;
            }

            for (int i = 1; i < checkNumArr.Length; i++)
            {
                if (checkNumArr[i] == false)
                    return i;

                if (i == checkNumArr.Length - 1 && checkNumArr[i] == true)
                    return i + 1;
            }

            return spi;
        }
    }
}
