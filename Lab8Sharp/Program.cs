using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using Lab8SharpLib;

namespace Lab8Sharp
{
    delegate bool MyDelegate(string s);
    
    class Program
    {
        static bool Method (string str)
        {
            int n = 0, s = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 67 && str[i] <= 90 || str[i] >= 97 && str[i] <= 122)
                {
                    s++;
                }
                else if (str[i] >= 48 && str[i] <= 57)
                {
                    n++;
                }
            }
            if (s > n)
                return true;
            else
                return false;
        }



        static void Main(string[] args)
        {
            MyDelegate mydelegate = Method;
            Console.WriteLine("str > numbers ? = {0}", mydelegate("dqwe12e2d1132qwed12`"));

            
            MyList mylist = new MyList(new string[] { "one", "two", "three" });
            MyList.Clear();
            
        }
    }
}
