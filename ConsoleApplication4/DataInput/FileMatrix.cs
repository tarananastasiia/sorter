using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class FileMatrix : IMatrixInputer
    {
        public string InputerName => "Ввод даних матриці у файлі";
        public int[,] GetMatrix()
        {
            List<int> stringInInt = new List<int>();
            Console.WriteLine("Введіть ссилку на файл!");
            string path = Console.ReadLine();
            string e = Path.GetExtension(path);

            if (e != ".txt")
            {
                Console.WriteLine("Невірний формат!Введіть ще раз!");
                return GetMatrix();
            }
            if (File.Exists(path) == false)
            {
                Console.WriteLine("Файл не знайдено!Введіть ще раз!");
                return GetMatrix();
            }

            string[] sentense = File.ReadAllLines(path);
            int rowCount = sentense.Length;
            int columnCount = sentense.Select(x => x.Split(' ').Length).Min();
            int[,] result = new int[rowCount, columnCount];

            try
            {
                for (int r = 0; r < rowCount; r++)
                {
                    string[] row = sentense[r].Split(' ');
                    for (int c = 0; c < columnCount; c++)
                    {
                        result[r, c] = Int32.Parse(row[c]);
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Невірна матриця у файлі!Перевірте дані у файлі!");
                return GetMatrix();
            }

            return result;

            //// @"C:\Users\home_pc\Desktop\file.txt

            //for (int i = 0; i < sentense.Length; i++)
            //{
            //    string[] split = sentense[i].Split(' ');
            //    for (int j = 0; j < split.Length; j++)
            //    {
            //        stringInInt.Add(Int32.Parse(split[j]));

            //        //if (split[j].Length != split[j + 1].Length)
            //        //{
            //        //    Console.WriteLine("Невірна матриця у файлі!Перевірте дані у файлі!");
            //        //    return GetMatrix();
            //        //}

            //    }
            //}
            //int[,] fileMas = new int[sentense.Length, stringInInt.Count / sentense.Length];
            //int x = 0;
            //for (int j = 0; j < sentense.Length; j++)
            //{
            //    for (int k = 0; k < stringInInt.Count / sentense.Length; k++)
            //    {
            //        fileMas[j, k] = stringInInt[x];
            //        x++;
            //    }
            //}
            //return fileMas;
        }
    }
}
