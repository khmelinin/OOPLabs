using System;

namespace Lab2SharpLib
{
    public static class Str
    {
        private static int size = 0;
        private static char[] str;
        static Str()
        {
            size = 0;
            str = new char[size];
        }
        Str(char[]s)
        {
            size = 
            str = new char[size];
            for (int i = 0; i < size; i++)
            {
                str[i] = s[i];
            }
        }
    }
}
