using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Виберіть спосіб вводу даних:" + '\n' + "1-В консолі." + '\n' + "2-В файлі.");
            int x = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            if (x == 1)
            {
                Console.WriteLine("Введіть розмірність матриці даних:");
                int line = Convert.ToInt32(Console.ReadLine());
                int column = Convert.ToInt32(Console.ReadLine());
                int[,] mas = new int[line, column];
                int[] mas1 = new int[line * column];
                int z = 0;
                Console.WriteLine("Заповніть матрицю:");
                for (int i = 0; i < line; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        mas[i, j] = Convert.ToInt32(Console.ReadLine());
                        mas1[z] = mas[i, j];
                        z++;
                    }
                }
                BubbleSorter sort1 = new BubbleSorter();
                sort1.BubbleSort(mas1);

                Matrix matrix = new Matrix();
                mas=matrix.CreateMatrix(mas1,line,column);
            }
            Console.ReadLine();
        }
    }

}
