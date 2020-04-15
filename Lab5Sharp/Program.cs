using System;

namespace Lab5Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            NUMSTR a = new NUMSTR(123);
            a.Del('2');
            a.print();
            Console.Write("NUMSTR size = ");
            Console.WriteLine(a.getSize());
            Console.WriteLine();

            double[,] tt = { { 1, 5 }, { 3, 5 }, { 4, 0 }, { 0, 0 } };
            Trapez t = new Trapez(tt);
            Circle c = new Circle(4);
            Console.Write("Trapez S = ");
            Console.WriteLine(t.S());
            Console.Write("Trapez P = ");
            Console.WriteLine(t.P());

            Console.Write("Circle S = ");
            Console.WriteLine(c.S());
            Console.Write("Circle P = ");
            Console.WriteLine(c.P());
        }
    }
}
