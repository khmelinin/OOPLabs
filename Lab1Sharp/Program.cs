using System;

namespace Lab1Sharp
{
    class Program
    {
        static void PlusOne(ref int a, ref int b)
        {
        }
        static void Main(string[] args)
        {
            int a = 43, b = 1;
            PlusOne(ref a, ref b);
           
        }
    }
}
