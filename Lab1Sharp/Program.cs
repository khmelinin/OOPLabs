using System;

namespace Lab1Sharp
{
    class Program
    {
        static void PlusOne(ref int a)
        {
            for (int i = 1; ((a ^= i) & i) == 0; i <<= 1) ;
        }

        static bool Comparing(int a, int b)
        {
            return (a ^ b) == 0;
        }

        static void Main(string[] args)
        {
            int a = -43, b = -42;
            PlusOne(ref a);
            bool c = Comparing(a, b);
           
        }
    }
}
