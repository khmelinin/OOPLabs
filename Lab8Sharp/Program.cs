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
            Console.WriteLine("FROM PROGRAM: str > numbers ? = {0}", mydelegate("dqwe12e2d1132qwed12`"));

            
            MyList<string> mylist = new MyList<string>(new string[] { "one", "two", "three" });
            MyList<string>.ClearS();
            MyList<string>.MyDelegate static_delegate = MyList<string>.MethodS;
            MyList<string>.MyDelegate non_static_delegate = mylist.MethodNS;

            Console.WriteLine("FROM MyList(static): str > numbers ? = {0}", static_delegate("dqwe12e2d1132qwed12`"));
            Console.WriteLine("FROM MyList(non static): str > numbers ? = {0}", non_static_delegate("dqwe12e2d1132qwed12`"));
        }
    }
}
