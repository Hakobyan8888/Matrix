using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class MatrixMultiplication
    {
        Matrix matrix = new Matrix("Hello");
        public void MultiplyMatrix(int[,] arr1, int[,] arr2)
        {

            int[,] answer = new int[arr1.GetLength(0), arr1.GetLength(1)];
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    answer[i, j] = 0;
                    for (int k = 0; k < arr1.GetLength(1); k++)
                    {
                        answer[i, j] += arr1[i, k] * arr2[k, j];
                    }
                }
            }
            matrix.PrintMatrix(answer, "The multiply is");
            /*
            Console.WriteLine("The answer is");
            for (int i = 0; i < answer.GetLength(0); i++)
            {
                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    Console.Write(answer[i, j] + " ");
                }
                Console.WriteLine();
            }
            */
        }
    }
}
