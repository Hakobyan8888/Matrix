using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new Matrix();
            var matrixAddition = new MatrixAddition();
            var matrixMultiplication = new MatrixMultiplication();
            var scalarMultiplication = new ScalarMutiplication();
            var transpose = new TransposeMatrix();

            int[,] arr1 = matrix.CreateMatrix();
            int[,] arr2 = matrix.CreateMatrix();

            matrix.PrintMatrix(arr1,"The first matrix is ");
            matrix.PrintMatrix(arr2, "The second matrix is ");
            matrixAddition.AddMatrix(arr1 , arr2);
            matrixMultiplication.MultiplyMatrix(arr1, arr2);
            scalarMultiplication.ScalarMatrix(arr1,5);
            transpose.TransMatrix(arr1);
            Console.ReadLine();
        }
    }
}
