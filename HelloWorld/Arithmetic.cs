using HelloWorld.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Arithmetic : IArithmetic
    {
        public int Add(int a, int b)
        {
            return Math.Abs(a + b);
        }

        public int Multiply(int a, int b)
        {
            return Math.Abs(a * b);
        }

        public int Subtract(int a, int b)
        {
            return Math.Abs(a - b);
        }
    }
}
