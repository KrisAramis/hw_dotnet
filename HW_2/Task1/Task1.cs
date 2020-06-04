using System;
using System.Collections;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 3;
           byte a = 2;
           int c = a+b;

            int e = 3;
            float d = a;

            sbyte f = -9;
            short g = f;

            ushort i = 0;
            short w = (short) i;

            double y = 4.0;
            decimal u = (decimal)a;

            int s = 33;
            int h = 600;
            byte j = (byte)(h + s);

            //boxing
            ArrayList k = new ArrayList();
            int n = 9;
            k.Add(n);

            //unboxing
            
            object box = 12;
            int t = (int)box;
        }
    }
}
