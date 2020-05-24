using System;
//variant 13

namespace Lab7Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection a = new MyCollection("asdf*g#hjk*ghj*");
            Console.WriteLine(a.FindCount('*'));
            a.DelAfter('#');
            Console.WriteLine(a.FindCount('*'));
        }
    }
}
