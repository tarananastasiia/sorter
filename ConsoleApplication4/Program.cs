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

            Console.WriteLine("Виберіть спосіб вводу даних:" + '\n' + "1-В консолі." + '\n' + "2-В файлі." + '\n'
                + "3-Рандомно.");
            int x = Convert.ToInt32(Console.ReadLine());

            ISort sorter;
            IMatrixInputer inputer;
            ArrayTranspontator array = new ArrayTranspontator();
            string sorterMenu = "Оберіть метод сортування:" + '\n' + "1-Метод бульбашки" + '\n' +
                    "2-Швидка сортіровка" + '\n' + "3-Шейкерна сортіровка" + '\n' + "4-Випадкова сортіровка";
            if (x == 1)
            {
                inputer = new ConsolMatrix();
                int[,] m = inputer.GetMatrix();

                Console.WriteLine(sorterMenu);
                int y = Convert.ToInt32(Console.ReadLine());
                if (y == 1)
                {
                    sorter = new BubbleSorter();
                }
                else if (y == 2)
                {
                    sorter = new QuickSorter();
                }
                else if (y == 3)
                {
                    sorter = new ShakerSorter();
                }
                else
                {
                    sorter = new BogoSorter();
                }

                MatrixTranspontator matrix = new MatrixTranspontator();
                matrix.CreateMatrix(sorter.Sort(array.TranslationIntoAOneDimensionalArray(m)), m.GetLength(0),
                    m.GetLength(1));
            }
            if (x == 2)
            {
                inputer = new FileMatrix();
                int[,] m = inputer.GetMatrix();

                Console.WriteLine(sorterMenu);
                int y = Convert.ToInt32(Console.ReadLine());

                if (y == 1)
                {
                    sorter = new BubbleSorter();
                }
                else if (y == 2)
                {
                    sorter = new QuickSorter();
                }
                else if (y == 3)
                {
                    sorter = new ShakerSorter();
                }
                else
                {
                    sorter = new BogoSorter();
                }

                MatrixTranspontator matrix = new MatrixTranspontator();
                matrix.CreateMatrix(sorter.Sort(array.TranslationIntoAOneDimensionalArray(m)), m.GetLength(0),
                    m.GetLength(1));
            }
            if (x == 3)
            {
                inputer = new RandomMatrix();
                int[,] m = inputer.GetMatrix();

                Console.WriteLine(sorterMenu);
                int y = Convert.ToInt32(Console.ReadLine());
                if (y == 1)
                {
                    sorter = new BubbleSorter();
                }
                else if (y == 2)
                {
                    sorter = new QuickSorter();
                }
                else if (y == 3)
                {
                    sorter = new ShakerSorter();
                }
                else
                {
                    sorter = new BogoSorter();
                }

                MatrixTranspontator matrix = new MatrixTranspontator();
                matrix.CreateMatrix(sorter.Sort(array.TranslationIntoAOneDimensionalArray(m)),
                    m.GetLength(0),
                    m.GetLength(1));
            }
            stopwatch.Stop();
            Console.WriteLine($"time is: { stopwatch.ElapsedMilliseconds}");
            Console.ReadLine();
        }
    }
}
