using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2SharpLib
{
    public class Text
    {
        private Str[] text;
        public Text(Str[] a)
        {
            text = new Str[a.Length];
            a.CopyTo(text, 0);
        }

        public void Add(Str a)
        {

        }
    }
}
