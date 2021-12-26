using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Iterations
{
    public class BinaryGap
    {
        public static int Solution(int N)
        {
            var binaryGap = 0;
            var binaryFormat = "";
            var zeroCount = 0;

            while (N > 0)
            {
                int remainder = N % 2;
                binaryFormat = remainder.ToString() + binaryFormat;
                N /= 2;
            }

            // or binaryFormat = Convert.ToString(N, 2);

            var charArr = binaryFormat.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == '0')
                    zeroCount++;
                else
                {
                    if (zeroCount > binaryGap)
                        binaryGap = zeroCount;

                    zeroCount = 0;
                }

            }


            return binaryGap;
        }
    }
}
