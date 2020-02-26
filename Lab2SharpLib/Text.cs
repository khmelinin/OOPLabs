using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2SharpLib
{
    public class Text
    {
        private Str[] text = null;
        public Text()
        {
            text = new Str[] { };
        }
        public Text(Str[] a)
        {
            text = new Str[a.Length];
            a.CopyTo(text, 0);
        }

        public void Add(Str a)
        {
            Array.Resize(ref text, text.Length + 1);
            text[text.Length - 1] = a;
        }
        public void Del()
        {
            Array.Resize(ref text, text.Length - 1);
        }
        public void Clear()
        {
            text = null;
            text = new Str[] { };
        }
        public Str Biggest()
        {
            int k = 0, index = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].getSize() > k)
                {
                    k = text[i].getSize();
                    index = i;
                }
            }
            return text[index];
        }

        public int Elements()
        {
            int e = 0;
            for (int i = 0; i < text.Length; i++)
            {
                e += text[i].getSize();
            }
            return e;
        }

        public double NumbersPercentage()
        {
            int e = Elements();
            int n = 0;
            for (int i = 0; i < text.Length; i++)
            {
                n += text[i].Numbers();
            }
            return 100 * n / e;
        }
    }
}
