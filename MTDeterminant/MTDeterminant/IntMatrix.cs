﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTDeterminant
{
    public class IntMatrix : Matrix<int>
    {
        public IntMatrix(int[,] array, int[] mArray, int[] nArray, int m, int n) : base(array, (x, y) => x + y, (x, y, s) => x * y * s, mArray, nArray, m, n)
        {

        }
    }
}
