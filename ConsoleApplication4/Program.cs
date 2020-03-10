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

        static List<IMatrixInputer> _inputers = new List<IMatrixInputer>()
            {
                new ConsolMatrix(),
                new FileMatrix(),
                new RandomMatrix()
            };

        static List<ISorter> _listOfSorters = new List<ISorter>()
            {
                new BubbleSorter(),
                new QuickSorter(),
                new ShakerSorter(),
                new BogoSorter()
            };

        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            IMatrixInputer inputer = InputMethod();
            ISorter sorter = SorterSelection();
            ArrayTranspontator array = new ArrayTranspontator();

            int[,] mas = inputer.GetMatrix();

            MatrixTranspontator matrix = new MatrixTranspontator();
            matrix.CreateMatrix(sorter.Sort(array.TranslationIntoAOneDimensionalArray(mas)), mas.GetLength(0),
                mas.GetLength(1));

            stopwatch.Stop();
            Console.WriteLine($"time is: { stopwatch.ElapsedMilliseconds}");
            Console.ReadLine();
        }
        private static IMatrixInputer InputMethod()
        {

            Console.WriteLine("Оберіть спосіб вводу даних в матрицю: ");
            for (int i = 0; i < _inputers.Count; i++)
            {
                Console.WriteLine($"{i + 1}- {_inputers[i].InputerName}");
            }

            int dataEntrySelectionNumber;
            string a = Console.ReadLine();
            if (!int.TryParse(a, out dataEntrySelectionNumber))
            {
                Console.WriteLine("Некоректний ввод");
                return InputMethod();
            }
            try
            {
                if (dataEntrySelectionNumber > _inputers.Count || dataEntrySelectionNumber < 1)
                {
                    throw new OverflowException();
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Возникло исключение!Введіть ще раз!");
                return InputMethod();
            }

            var inputer = _inputers[dataEntrySelectionNumber - 1];
            return inputer;
        }


        private static ISorter SorterSelection()
        {

            Console.WriteLine("Оберіть метод сортування:");
            for (int i = 0; i < _listOfSorters.Count; i++)
            {
                Console.WriteLine($"{i + 1}- {_listOfSorters[i].SortName}");
            }

            int sortMethodSelectionNumber;
            string b = Console.ReadLine();
            if (!int.TryParse(b, out sortMethodSelectionNumber))
            {
                Console.WriteLine("Некоректний ввод");
                return SorterSelection();
            }
            try
            {
                if (sortMethodSelectionNumber > _listOfSorters.Count || sortMethodSelectionNumber < 1)
                {
                    throw new OverflowException();
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Возникло исключение!Введіть ще раз!");
                return SorterSelection();
            }
            var sorter = _listOfSorters[sortMethodSelectionNumber - 1];
            return sorter;
        }
    }
}
