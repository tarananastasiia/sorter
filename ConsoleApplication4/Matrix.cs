using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Matrix
    {
        public T[,] CreateMatrix<T>(T[] array,int x,int y)
        {

            //int len = array.Length;
            //var rows = (int)(len / Math.Sqrt(len));
            //if (rows <= 0) rows = 1;
            //int col = array.Length / rows;
            //var matrix = new T[rows, col];
            //for (int i = 0; i < len; i++)
            //{
            //    matrix[i / rows, i % rows] = array[i];
            //}

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
