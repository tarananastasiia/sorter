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

            int line;
            string a = Console.ReadLine();
            if (!int.TryParse(a, out line) || line < 1)
            {
                Console.WriteLine("Некоректний ввод");
                return GetMatrix();
            }

            int column;
            string b = Console.ReadLine();
            if (!int.TryParse(b, out column) || column < 1)
            {
                Console.WriteLine("Некоректний ввод");
                return GetMatrix();
            }
            return ConsolMethod(line, column);
        }
        private static int[,] ConsolMethod(int line, int column)
        {
            int[,] mas = new int[line, column];
            int z = 0;
            Console.WriteLine("Заповніть матрицю:");
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    z++;
                    string a = Console.ReadLine();
                    if (!int.TryParse(a, out mas[i, j]))
                    {
                        Console.WriteLine("Некоректний ввод");
                        return ConsolMethod(line,column);
                    }
                }
            }
            return mas;
        }
    }
}
