using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new Matrix();
            var matrixController = new MatrixController();
            
            int[,] arr1 = matrix.CreateMatrix();
            int[,] arr2 = matrix.CreateMatrix();
            matrix.PrintMatrix(arr1, "Your 1st Matrix is");
            matrix.PrintMatrix(arr2, "Your 2nd Matrix is");
            Console.WriteLine("Enter the Scalar Number");
            int Number = int.Parse(Console.ReadLine());

            matrixController.Chooser(arr1, arr2, Number);

            Console.ReadLine();
        }
    }
}
