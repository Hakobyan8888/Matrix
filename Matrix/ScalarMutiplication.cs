using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class ScalarMutiplication
    {
        Matrix matrix = new Matrix("Hello");
        public void ScalarMatrix(int[,] arr, int value)
        {
            int Row = arr.GetLength(0);
            int Column = arr.GetLength(1);
            int[,] answer = new int[Row, Column];
            for(int i = 0; i < Row; i++)
            {
                for(int j = 0; j < Column; j++)
                {
                    answer[i, j] = arr[i, j] * value;
                }
            }
            matrix.PrintMatrix(answer,"This is Scalar Multiplication");
        }
    }
}
