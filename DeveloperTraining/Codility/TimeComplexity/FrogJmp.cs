using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.TimeComplexity
{
    public class FrogJmp
    {
        public static int Solution(int X, int Y, int D)
        {
            var actualDistance = Y - X;

            var minStep = (double)actualDistance/D;

            return Convert.ToInt32(Math.Ceiling(minStep));
        }
    }
}
