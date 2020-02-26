using System;

namespace Lab2SharpLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Str h = new Str(new char[] { 'h', 'e', 'l', 'l', 'o', ' '});
            Str w = new Str(new char[] { 'w', 'o', 'r', 'l', 'd','3'});
            Text t = new Text(new Str[] {h});
            t.Add(w);
        }
            
    }
}
