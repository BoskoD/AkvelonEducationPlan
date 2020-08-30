using System;

namespace Arrays_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------Single Dimensional---------------------

            // Declare a single dimensional array of 5 elements
            int[] array1 = new int[5];
            // Declare and set array element values
            int[] array2 = new int[] { 1, 2, 3, 4, 5 };
            // Alternative syntax
            int[] array3 = { 7, 8, 9, 3, 65 };


            // Iterate
            foreach (int item in array3)
            {
                Console.WriteLine("This is single dimensional array by elements: {0}", item);
            }
            Console.WriteLine();




            // ---------Two Dimensional---------------------
            // Declare a two dimensional array
            int[,] multidimensionalArray1 = new int[2, 3];
            // Declare and set array element values
            int[,] multidimensionalArray2 = { { 2, 3, 4 }, { 13, 12, 27 } };


            // Iterate
            foreach (int item in multidimensionalArray2)
            {
                Console.WriteLine("This is multidimensional array by elements: {0}", item);
            }
            Console.WriteLine();


            // ---------Jagged Array---------------------
            // Declare a jagged array
            int[][] jaggedArray = new int[2][];
            // Set values of the first and second jagged array int the jagged array structure
            jaggedArray[0] = new int[4] { 27, 4, 19, 91 };
            jaggedArray[1] = new int[4] { 07, 10, 19, 92 };


            // Iterate
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine("Jagged array - Elements({0}): ", i);

                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine("{0}{1}", jaggedArray[i][j], j == (jaggedArray[i].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
            }



        }
    }
}
