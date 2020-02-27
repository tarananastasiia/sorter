using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class BogoSorter
    {
        public  bool IsSorted(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] > a[i + 1])
                    return false;
            }
            return true;
        }
        public int[] RandomPermutation(int[] a)
        {
            Random random = new Random();
            var n = a.Length;
            while (n > 1)
            {
                n--;
                var i = random.Next(n + 1);
                var temp = a[i];
                a[i] = a[n]; 
                a[n] = temp;
                
            }
            return a;
        }
        public int[] BogoSort(int[] a)
        {
            while (!IsSorted(a))
            {

                a = RandomPermutation(a);
            }
            return a;
        }
    }
}
