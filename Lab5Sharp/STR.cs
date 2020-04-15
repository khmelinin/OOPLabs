using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5Sharp
{
    class STR
    {
        protected char[] str;
        public STR(string s)
        {
            str = new char[s.Length];
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = s[i];
            }

        }
        public int getSize()
        {
            return str.Length;
        }
        public void print()
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }
    }
}
