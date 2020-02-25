using System;

namespace Lab2SharpLib
{
	public class Str
	{
		private char[] str;
		public Str(char[] s)
		{
			str = new char[s.Length];
			s.CopyTo(str, 0);
		}
		public int Find(char[] s)
		{
			int k = 0;
			int index = -1;
			for (int i = 0; i < str.Length; i++)

			{
				if (str[i] == s[0])
				{
					for (int j = 0; j < s.Length + 1; j++)
					{
						if (str[i] == s[j])
							k++;
					}
				}
				if (k == s.Length)
				{
					index = i;
					return index;
				}
			}
			return index;
		}

		public void Add(char[] s)
		{
			for (int i = str.Length; i < (str.Length + s.Length); i++)
			{
				str[i] = s[i - str.Length];
			}
		}

		public void Del(char[] s)
		{
			for (int i = Find(s); i < (str.Length - s.Length); i++)
			{
				str[i] = str[i + s.Length];
			}
		}

		public int Numbers()
		{
			int n = 0;
			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] >= 48 && str[i] <= 57)
					n++;
			}
			return n;
		}

	}
}
