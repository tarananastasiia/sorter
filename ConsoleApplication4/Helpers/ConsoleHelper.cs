using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Helpers
{
    public static class ConsoleHelper
    {
        public static int GetNumber(Func<int, bool> validation = null)
        {
            int result;
            string b = Console.ReadLine();
            if (!int.TryParse(b, out result))
            {
                Console.WriteLine("Некоректний ввод");
                return GetNumber();
            }
            if (validation != null && validation(result) == false)
            {
                Console.WriteLine("Некоректний ввод");
                return GetNumber();
            }
            return result;
        }
    }
}
