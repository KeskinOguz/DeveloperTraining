﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = new int[] { 9,3,9,3,9,7,9 };

            var totalCountDict = new Dictionary<int, int>();

            var result = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (totalCountDict.ContainsKey(A[i]))
                {
                    totalCountDict[A[i]]++;
                }
                else
                    totalCountDict.Add(A[i], 1);
            }


            foreach (var item in totalCountDict)
            {
                if (item.Value % 2 == 1)
                {
                    result = item.Key;
                    break;
                }
            }


        }
    }
}
