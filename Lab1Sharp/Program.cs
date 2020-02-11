using System;

namespace Lab1Sharp
{
    class Program
    {
        static void PlusOne(ref int a)
        {
            for (int i = 1; ((a ^= i) & i) == 0; i <<= 1) ;
        }
        static void Main(string[] args)
        {
            int a = -43;
            PlusOne(ref a);
           
        }
    }
}
