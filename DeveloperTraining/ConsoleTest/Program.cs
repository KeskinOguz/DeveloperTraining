﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 3,1 };
            var result = solution(arr);
            Console.WriteLine(result.ToString());
            Console.ReadKey();

        }

        public static int solution(int[] A)
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
