using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class Matrix
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Matrix(string a)
        {
            a = "Hello";
        }

        public Matrix()
        {
            Console.WriteLine("Enter the Number of Row's");
            Row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number of Column's");
            Column = int.Parse(Console.ReadLine());
        }

        public int[,] CreateMatrix()
        {
            int[,] matrix = new int[Row, Column];
            Console.WriteLine("Write the array");
            for(int i = 0; i < Row; i++)
            {
                for(int j = 0; j < Column; j++)
                {
                    matrix[i , j] = int.Parse(Console.ReadLine());
                }
            }
            return matrix;
        }

        public void PrintMatrix(int[,] arr, string About)
        {
            Row = arr.GetLength(0);
            Column = arr.GetLength(1);
            Console.WriteLine(About);
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    Console.Write(arr[i , j] + " ");
                }
                Console.WriteLine();
            }
        }

        

    }
}
