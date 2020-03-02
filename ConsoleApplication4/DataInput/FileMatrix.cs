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
        public int[,] GetMatrix()
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
            int[,] fileMas = new int[sentense.Length, stringInInt.Count / sentense.Length];
            int x = 0;
            for (int j = 0; j < sentense.Length; j++)
            {
                for (int k = 0; k < stringInInt.Count / sentense.Length; k++)
                {
                    fileMas[j, k] = stringInInt[x];
                    x++;
                }
            }
            return fileMas;
        }
    }
}
