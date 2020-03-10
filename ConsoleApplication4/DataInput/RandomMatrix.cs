using ConsoleApplication4.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class RandomMatrix : IMatrixInputer
    {
        public string InputerName => "Ввод даних матриці рандомно";
        public int[,] GetMatrix()
        {
            Console.WriteLine("Введіть розмірність матриці  даних:");

            int line = ConsoleHelper.GetNumber(x => x > 1);
            int column = ConsoleHelper.GetNumber(x => x > 1);
            return RandomMethod(line, column);
        }

        private int[,] RandomMethod(int line, int column)
        {
            int[,] mas = new int[line, column];
            Random random = new Random();
            Console.WriteLine("ВВедіть границі рандомних чисел, що будуть в матриці:");

            int min = ConsoleHelper.GetNumber();

            int max = ConsoleHelper.GetNumber();

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    mas[i, j] = random.Next(min, max);
                }
            }
            return mas;
        }


    }
}
