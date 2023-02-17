using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractise
{
    public delegate void MathDel(double x, double y);
    class MyMath
    {
        public static void Add(double x, double y) => Console.WriteLine(x + y);
        public static void Sub(double x, double y) => Console.WriteLine(x-y);
        public static void Mult(double x, double y) => Console.WriteLine(x*y);

    }
}
