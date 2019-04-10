using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class MatrixAddition
    {
        Matrix matrix = new Matrix("Hello");
        public void AddMatrix(int[,] arr, int[,] arr2)
        {
            int row = 0;
            int column = 0;
            row = arr.GetLength(0);
            column = arr2.GetLength(1);

            int[,] answer = new int[row , column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    answer[i,j] = arr[i , j] + arr2[i , j];
                    //Console.Write(answer[i, j]+ " ");
                }
                //Console.WriteLine();
            }
            matrix.PrintMatrix(answer,"The Add is");
        }
    }
}
