using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Panofy
{
    public class Calculator
    {
        public int Add(int A, int B)
        {
            return A + B;
        }

        public int Divide(int A, int B)
        {
            return A - B;
        }

        public double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }
    }
}