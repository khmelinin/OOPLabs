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
            int aa, bb, ii;
            for (int i = 0; i < 32; i++)
            {
                ii = 1 << i;
                aa = a & ii;
                bb = b & ii;
                if ((aa ^ bb)==1)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int a = -43, aa = 75, aaa = 63;
            int b = 48, bb = 69, bbb = 24;
            int c = 48, cc = 78, ccc = 25;
            PlusOne(ref a);
            PlusOne(ref aa);
            PlusOne(ref aaa);

            bool ComparingBC = Comparing(b, c);
            bool ComparingBBCC = Comparing(bb, cc);
            bool ComparingBBBCCC = Comparing(bbb, ccc);

        }
    }
}
