using System;
using System.Collections.Generic;

namespace Lab8SharpLib
{
    public class MyList
    {
        public delegate void ClearHandler(string message);
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
        public delegate void clear();
        public static clear Clear = () => { l.Clear(); Notify?.Invoke($"Clear()"); };

        public List<string> L { get => l; set => l = value; }
    }
}
