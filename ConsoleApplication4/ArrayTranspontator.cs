using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class ArrayTranspontator
    {
        public int [] TranslationIntoAOneDimensionalArray(int[,] one_dimensionalArray)
        {
            int[] m1 = new int[one_dimensionalArray.GetLength(0)*one_dimensionalArray.GetLength(1)];
            int z = 0;
            for (int i = 0; i < one_dimensionalArray.GetLength(0); i++)
                for (int j = 0; j < one_dimensionalArray.GetLength(1); j++)
                {
                    m1[z] = one_dimensionalArray[i, j];
                    z++;
                }
            return m1;
        }

        public T[,] CreateMatrix<T>(T[] array, int rows, int col)
        {
            var matrix = new T[rows, col];
            for (int i = 0; i < array.Length; i++)
            {
                matrix[i / col, i % col] = array[i];
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }
            return matrix;
        }
    }
}
