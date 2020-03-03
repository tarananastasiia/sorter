using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class ConsolMatrix : IMatrixInputer
    {
        public string InputerName => "Ввод даних матриці в консолі";
        public int[,] GetMatrix()
        {
            Console.WriteLine("Введіть розмірність матриці  даних:");
            int line = Convert.ToInt32(Console.ReadLine());
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[line, column];
            int z = 0;
            Console.WriteLine("Заповніть матрицю:");
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    mas[i, j] = Convert.ToInt32(Console.ReadLine());
                    z++;
                }
            }
            return mas;
        }
    }
}
