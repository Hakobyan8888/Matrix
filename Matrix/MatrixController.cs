using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class MatrixController
    {
        Matrix matrix = new Matrix("Hello");
        MatrixAddition matrixAddition = new MatrixAddition();
        MatrixMultiplication matrixMultiplication = new MatrixMultiplication();
        ScalarMutiplication scalarMultiplication = new ScalarMutiplication();
        TransposeMatrix transpose = new TransposeMatrix();
        BiggestAndSmallest biggestAndSmallest = new BiggestAndSmallest();
        public int Choose { get; set; }

        public void Chooser(int[,] arr1,int[,] arr2, int num)
        {
            Console.WriteLine("Choose The Operations");
            Console.WriteLine("1.Matrix Addition");
            Console.WriteLine("2.Matrix Multiplication");
            Console.WriteLine("3.Matrix Scalar Multiplication");
            Console.WriteLine("4.Matrix Transpose");
            Console.WriteLine("5.Biggest and Smallest Number in Matrix");
            Console.WriteLine("6.All Together");
            
            switch (Choose = int.Parse(Console.ReadLine()))
            {
                case 1:
                    matrixAddition.AddMatrix(arr1 , arr2);
                    break;
                case 2:
                    matrixMultiplication.MultiplyMatrix(arr1, arr2);
                    break;
                case 3:
                    scalarMultiplication.ScalarMatrix(arr1, num);
                    break;
                case 4:
                    transpose.TransMatrix(arr1 , "array 1");
                    transpose.TransMatrix(arr2 , "array 2");
                    break;
                case 5:
                    biggestAndSmallest.Compare(arr1 , "array 1");
                    biggestAndSmallest.Compare(arr2 , "array 2");
                    break;
                case 6:
                    matrixAddition.AddMatrix(arr1, arr2);
                    matrixMultiplication.MultiplyMatrix(arr1, arr2);
                    scalarMultiplication.ScalarMatrix(arr1, num);
                    transpose.TransMatrix(arr1 , "array 1");
                    transpose.TransMatrix(arr2 , "array 2");
                    biggestAndSmallest.Compare(arr1 , "array 1");
                    biggestAndSmallest.Compare(arr2 , "array 2");
                    break;
            }
        }

    }
}
