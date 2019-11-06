using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 1.2, 1.5, 6.4, 7.9 };
            int[] arr1 = Copy_To_Int(arr);
            foreach (var el in arr1)
                Console.WriteLine(el);
            Console.WriteLine();
            
            Dell_Element(ref arr, 2);
            foreach (var el in arr)
                Console.WriteLine(el);
            Console.WriteLine();

            int[,] mtr = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
            Upper_Triang(mtr);
            Console.ReadLine();
        }


        static int[] Copy_To_Int(double[] arr_of_doubles)
        {
            int[] arr_of_ints = new int[arr_of_doubles.Length];
            for (int i = 0; i < arr_of_doubles.Length; ++i)
            {
                arr_of_ints[i] = (int)arr_of_doubles[i];
            }
            return arr_of_ints;
        }

        static void Dell_Element<T>(ref T[] arr, int idx)
        {
            T[] temp = new T[arr.Length - 1];
            for (int i = 0, j = 0; i < arr.Length; ++i)
            {
                if (i != idx)
                {
                    temp[j] = arr[i];
                    ++j;
                }
            }
            arr = temp;
        }

        static void Upper_Triang<T>(T[,] mtr)
        {
            int row = mtr.GetLength(0);
            int column = mtr.GetLength(1);
            T[,] temp = new T[row, column];
            Array.Copy(mtr, temp, mtr.Length);
            for (int i = 0, j = 1; i < row; ++i)
            {   
                while (j < i && j < column)
                {
                    temp[i, j] = default(T);
                    ++j;
                }
                j = 0;
            }

            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < column; ++j)
                    Console.Write($"{temp[i,j]} ");
                Console.WriteLine();
            }
        }
    }
}
