using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public interface IMatrixInputer
    {
        string InputerName { get; }
        int[,] GetMatrix();
    }
}
