using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class RandomMatrix:IMatrixInputer
    {
        public string InputerName => "Ввод даних матриці рандомно";
        public int[,] GetMatrix()
        {
            Console.WriteLine("Введіть розмірність матриці  даних:");
            int line = Convert.ToInt32(Console.ReadLine());
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[line, column];
            Random random = new Random();
            Console.WriteLine("ВВедіть границі рандомних чисел, що будуть в матриці:");
            int min = Convert.ToInt32(Console.ReadLine());
            int max = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    mas[i,j] = random.Next(min, max);
                }
            }
            return mas;
        }
    }
}
