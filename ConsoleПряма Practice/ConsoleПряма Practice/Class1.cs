using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleПряма_Practice
{
    internal class Parallelogram
    {
        private int a;
        private int b;
        private double angle;
        private int result;

        public void Sets(int a1, int b2, int angle1)
        {
            a = a1;
            b = b2;
            angle = angle1;
        }
        public void Perimetr()
        {
            Console.WriteLine("Периметр:");
            Console.Write(2 * (a + b));
            Console.WriteLine();
        }
        public void Ploscha()
        {
            result = Convert.ToInt32(a * b * (Math.Sin(Math.PI * angle / 180)));
            Console.WriteLine("Площа");
            Console.WriteLine(result);
            Console.WriteLine();
        }

    }
}
