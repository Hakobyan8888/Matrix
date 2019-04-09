using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class MatrixAddition
    {
        Matrix matrix;
        public void AddMatrix(int[,] arr, int[,] arr2)
        {
            int row = 0;
            if (arr.GetLength(0)>arr2.GetLength(0))
                row = arr.GetLength(0);
            else
                row = arr2.GetLength(0);
            int column = 0;
            if (arr.GetLength(1) > arr2.GetLength(1))
                column = arr.GetLength(1);
            else
                column = arr2.GetLength(1);
            int[,] answer = new int[row , column];
            Console.WriteLine("The answer is");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    answer[i,j] = arr[i , j] + arr2[i , j];
                    Console.Write(answer[i, j]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
