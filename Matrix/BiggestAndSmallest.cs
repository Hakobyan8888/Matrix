using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
    class BiggestAndSmallest
    {
        Matrix matrix = new Matrix("Hello");
        public void Compare(int[,] arr, string Name)
        {
            int Row = arr.GetLength(0);
            int Column = arr.GetLength(1);
            int Largest = 0;
            int Smallest = arr[0,0];
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    if (Largest < arr[i, j])
                    {
                        Largest = arr[i, j];
                    }
                    else if (Smallest > arr[i, j])
                    {
                        Smallest = arr[i, j];
                    }
                }
            }
            Console.WriteLine("The Largest Number of " + Name + " is " + Largest);
            Console.WriteLine("The Smallest Number of " + Name + " is " + Smallest);
        }
    }
}
