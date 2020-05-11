using System;
using System.Collections.Generic;

namespace Lab8SharpLib
{
    public class MyList
    {
        public delegate void ClearHandler(string message);
        public delegate bool MyDelegate(string s);
        public static event ClearHandler Notify = DisplayMessage;
        static List<string> l;
        public MyList(string[] s)
        {
            l = new List<string>(s);
        }
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static bool MethodS(string str)
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

        public bool MethodNS(string str)
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
        public delegate void clear();
        public static clear ClearS = () => { l.Clear(); Notify?.Invoke($"Clear()"); };
        public clear ClearE = () => { l.Clear(); Notify?.Invoke($"Clear()"); };

        public List<string> L { get => l; set => l = value; }
    }
}
