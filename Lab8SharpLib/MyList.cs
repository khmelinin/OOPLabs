using System;
using System.Collections.Generic;

namespace Lab8SharpLib
{
    public class MyList<T>
    {
        public delegate void ClearHandler(string message);
        public delegate bool MyDelegate(string s);
        public static event ClearHandler Notify = DisplayMessage;
        static T[] data;
        public MyList(T[] s)
        {
            data = s;
        }
        public T Next(T dat)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Equals(dat))
                    return data[i + 1];
            }
            
            return dat;
        }

        public T Prev(T dat)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Equals(dat))
                    return data[i - 1];
            }

            return dat;
        }
        public void Add(T s)
        {
            T[] tmp = new T[data.Length + 1];
            for (int i = 0; i < data.Length; i++)
            {
                tmp[i] = data[i];
            }
            tmp[data.Length] = s;
            data = tmp;
        }
        public void Pop()
        {
            T[] tmp = new T[data.Length - 1];
            for (int i = 0; i < data.Length-1; i++)
            {
                tmp[i] = data[i];
            }
            data = tmp;
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
        public static clear ClearS = () => { data=new T[] { }; Notify?.Invoke($"Clear()"); };
        public clear ClearE = () => { data = new T[] { }; Notify?.Invoke($"Clear()"); };

        public T this[int i] { get => data[i]; set => data[i] = value; }
    }
}
