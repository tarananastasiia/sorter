using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine("Виберіть спосіб вводу даних:" + '\n' + "1-В консолі." + '\n' + "2-В файлі.");
            int x = Convert.ToInt32(Console.ReadLine());
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
                Console.WriteLine("Оберіть метод сортування:" + '\n' + "1-Метод бульбашки" + '\n' +
                    "2-Швидка сортіровка" + '\n' + "3-Шейкерна сортіровка" + '\n' + "4-Випадкова сортіровка");
                int y = Convert.ToInt32(Console.ReadLine());
                if (y == 1)
                {
                    BubbleSorter bubbleSort = new BubbleSorter();
                    bubbleSort.BubbleSort(mas1);
                }
                if (y == 2)
                {
                    QuickSorter quick = new QuickSorter();
                    quick.QuickSort(mas1);
                }
                if (y == 3)
                {
                    ShakerSorter shaker = new ShakerSorter();
                    shaker.ShakerSort(mas1);
                }
                if (y == 4)
                {
                    BogoSorter bogo = new BogoSorter();
                    bogo.BogoSort(mas1);
                }
                Matrix matrix = new Matrix();
                mas = matrix.CreateMatrix(mas1, line, column);
            }
            if (x == 2)
            {
                List<int> stringInInt = new List<int>();
                string path = @"C:\Users\home_pc\Desktop\file.txt";
                string[] sentense = File.ReadAllLines(path);
                for (int i = 0; i < sentense.Length; i++)
                {
                    string[] split = sentense[i].Split(' ');
                    for (int j = 0; j < split.Length; j++)
                    {
                        stringInInt.Add(Int32.Parse(split[j]));
                    }
                }
                int[] fileMas = new int[stringInInt.Count];
                for (int k = 0; k < stringInInt.Count; k++)
                {
                    fileMas[k] = stringInInt[k];
                }
                Console.WriteLine("Оберіть метод сортування:" + '\n' + "1-Метод бульбашки" + '\n' +
                    "2-Швидка сортіровка" + '\n' + "3-Шейкерна сортіровка" + '\n' + "4-Випадкова сортіровка");
                int y = Convert.ToInt32(Console.ReadLine());
                int[,] mas = new int[sentense.Length, fileMas.Length / sentense.Length];
                if (y == 1)
                {
                    BubbleSorter bubbleSort = new BubbleSorter();
                    bubbleSort.BubbleSort(fileMas);
                }
                if (y == 2)
                {
                    QuickSorter quick = new QuickSorter();
                    quick.QuickSort(fileMas);
                }
                if (y == 3)
                {
                    ShakerSorter shaker = new ShakerSorter();
                    shaker.ShakerSort(fileMas);
                }
                if (y == 4)
                {
                    BogoSorter bogo = new BogoSorter();
                    bogo.BogoSort(fileMas);
                }
                Matrix matrix = new Matrix();
                mas = matrix.CreateMatrix(fileMas, sentense.Length, fileMas.Length / sentense.Length);
            }
            stopwatch.Stop();
            Console.WriteLine($"time is: { stopwatch.ElapsedMilliseconds}");
            Console.ReadLine();
        }
    }
}
