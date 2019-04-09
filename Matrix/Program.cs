using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            MatrixAddition matrixAddition = new MatrixAddition();
            int[,] arr1 = matrix.CreateMatrix();
            int[,] arr2 = matrix.CreateMatrix();
            matrix.PrintMatrix(arr1);
            matrix.PrintMatrix(arr2);
            matrixAddition.AddMatrix(arr1 , arr2);

            Console.ReadLine();
        }
    }
}
