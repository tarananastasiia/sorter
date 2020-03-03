﻿using System;
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

            ISort sorter=null;
            IMatrixInputer inputer = null;
            ArrayTranspontator array = new ArrayTranspontator();

            List<IMatrixInputer> inputers = new List<IMatrixInputer>()
            {
                new ConsolMatrix(),
                new FileMatrix(),
                new RandomMatrix()
            };

            List<ISort> nameSort = new List<ISort>()
            {
                new BubbleSorter(),
                new QuickSorter(),
                new ShakerSorter(),
                new BogoSorter()
            };

            Console.WriteLine("Оберіть спосіб вводу даних в матрицю: ");
            for (int i = 0; i < inputers.Count; i++)
            {
                Console.WriteLine($"{i + 1}- {inputers[i].InputerName}");
            }
            int dataEntrySelectionNumber = Convert.ToInt32(Console.ReadLine());

            inputer = inputers[dataEntrySelectionNumber - 1];

            int[,] mas = inputer.GetMatrix();

            Console.WriteLine("Оберіть метод сортування:");
            for (int i = 0; i < nameSort.Count; i++)
            {
                Console.WriteLine($"{i + 1}- {nameSort[i].SortName}");
            }
            int sortMethodSelectionNumber = Convert.ToInt32(Console.ReadLine());

            sorter = nameSort[sortMethodSelectionNumber - 1];

            MatrixTranspontator matrix = new MatrixTranspontator();
            matrix.CreateMatrix(sorter.Sort(array.TranslationIntoAOneDimensionalArray(mas)), mas.GetLength(0),
                mas.GetLength(1));

            stopwatch.Stop();
            Console.WriteLine($"time is: { stopwatch.ElapsedMilliseconds}");
            Console.ReadLine();
        }
    }
}
