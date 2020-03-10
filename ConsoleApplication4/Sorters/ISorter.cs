using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public interface ISorter
    {
        string SortName { get; }
        int[] Sort(int[] x);
    }
}
