using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class MatrixTranspontator
    {
        public T[,] CreateMatrix<T>(T[] array,int rows,int col)
        {
            var matrix = new T[rows, col];
            for (int i = 0; i < array.Length; i++)
            {
                matrix[i/col, i%col] = array[i];
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
