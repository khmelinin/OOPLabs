using System;

namespace Lab4Sharp
{
    class CS
    {
        private char[] cs;
        public CS()
        {
            cs = new char[] { };
        }
        public CS(char[] val)
        {
            cs = new char[val.Length];
            val.CopyTo(cs, 0);
        }
        public CS(int s)
        {
            cs = new char[s];
            
        }
        public char[] Properties { get => cs; set => value.CopyTo(cs, 0); }
        
        public CS(CS val):this(val.cs){ }
        public int getL() { return cs.GetLength(0); }
        public char[] getLine() { return cs; }
        public static CS operator +(CS cs1, CS cs2) 
        {
            CS result = new CS(cs1.getL()+cs2.getL());
            for (int i=0; i < result.getL(); i++)
            {
                if (i < cs1.getL())
                    result.cs[i] = cs1.cs[i];
                else
                    result.cs[i] = cs2.cs[i-cs1.getL()];
            }
            return result;
        }
        public static CS operator -(CS cs1, char cs2)
        {
            CS result = new CS(cs1.getL() -1);
            int i = 0;
           while(cs1.cs[i] != cs2 && i<result.getL())
            {
                result.cs[i] = cs1.cs[i];
                i++;
            }
            for (int j = i+1; j < result.getL()+1; j++)
            {
                result.cs[j-1] = cs1.cs[j];
            }
            return result;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            char[] c1 ={ 'a','s','d','f'};
            char[] c2 = { 'a', 'b', 'c', 'd' };
            char[] c3 = { 'e', '0', 'f', 'g' };
            CS cs1= new CS(c1);
            CS cs2 = new CS(c2);
            CS cs3 = new CS(c3);
            cs3 = cs3 - '0';
            cs1 = cs2 + cs3;
            Console.WriteLine(cs3.getLine());
            Console.WriteLine(cs1.getLine());
        }
    }
}
