using System;

namespace Convert2Dto1D
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int [,] i2Darray = new int[2, 3];
            Console.WriteLine("Enter a 2D array: ");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    i2Darray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int index = 0;
            int noRows = i2Darray.GetLength(0);
            int noColumns = i2Darray.GetLength(1);
            int [] i1Darray = new int [noRows * noColumns];

            for (int y = 0; y < noColumns; y++)
            {
                for (int x = 0; x < noRows; x++)
                {
                    i1Darray[index] = i2Darray[x, y];
                    index++;
                }
            }

            Console.WriteLine("The converted 1D array is: ");

            foreach(int item in i1Darray)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}
