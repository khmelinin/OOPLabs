using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5Sharp
{
    class NUMSTR : STR
    {
        public NUMSTR(int n) : base(Convert.ToString(n)) { }
        public void Del(char n)
        {
			char[] tmp = new char[str.Length-1];
			for (int i = 0; i < str.Length; i++)
			{
				tmp[i] = str[i];
				if (str[i] == n)
				{
					for (int ii = i; ii < Convert.ToString(str).Length - 1; ii++)
					{
						tmp[i] = str[i + 1];
					}
					str = tmp;
				}
			}
		}
		public char[] getStr()
		{
			return str;
		}
    }
}
