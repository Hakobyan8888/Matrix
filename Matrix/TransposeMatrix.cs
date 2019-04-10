using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class TransposeMatrix
    {
        Matrix matrix = new Matrix("Hello");
        public void TransMatrix(int[,] arr)
        {
            int Row = arr.GetLength(0);
            int Column = arr.GetLength(1);
            int[,] answer = new int[Row, Column];
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    answer[i, j] = arr[j, i];
                }
            }
            matrix.PrintMatrix(answer, "This is Transpose");
        }
    }
}
