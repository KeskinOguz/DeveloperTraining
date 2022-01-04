using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Arrays
{
    public class OddOccurrencesInArray
    {
        public  static int Solution(int[] A)
        {
            var totalCountDict = new Dictionary<int, int>();

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
                    return item.Key;
                   
                }
            }

            return 0;
        }
    }
}
