using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { -1, -3 };
            var result = solution(arr);
            Console.WriteLine(string.Join(',', result));
            Console.ReadKey();

        }

        public static int solution(int[] A)
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
