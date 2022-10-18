using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleПряма_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Parallelogram parallelogram = new Parallelogram();
            parallelogram.Sets(15, 24, 30);
            parallelogram.Perimetr();
            parallelogram.Ploscha();

        }
    }
}
