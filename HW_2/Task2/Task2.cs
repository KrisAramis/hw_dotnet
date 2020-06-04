using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            Console.WriteLine(a.GetType());
            Int32 u = 2;
            Console.WriteLine(u.GetType());
            byte b = 7;
            Console.WriteLine(b.GetType());
            System.Byte t = 103;
            Console.WriteLine(t.GetType());
            char d = '\u0420';
            Console.WriteLine(d.GetType());
            System.Char f = 'w';
            Console.WriteLine(f.GetType());
            object i = "hello there" ;
            Console.WriteLine(i.GetType());
            System.Object l = "he we";
            Console.WriteLine(l.GetType());
            string h = "name";
            Console.WriteLine(h.GetType());
            System.String o = "us";
            Console.WriteLine(o.GetType());
        }
    }
}
