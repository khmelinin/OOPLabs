#pragma once
#include "STR.h"
#include <string>

class NUMSTR:public STR
{
public:
	NUMSTR(int n)
	{
		string tmp = to_string(n);
		int s = tmp.size();
		char *res = new char[s];
		for (int i = 0; i < s; i++)
		{
			res[i] = tmp[i];
		}
		size = s;
		str = res;
	}
	void Del(char a)
	{
		for (int i = 0; i < size; i++)
		{
			if (str[i] == a)
			{
				for (int ii = i; ii < size - 1; ii++)
				{
					str[i] = str[i + 1];
				}
				delete [size-1]str;
				size--;
				return;
			}

			
		}
	}
	char* getStr()
	{
		return str;
	}

	void print()
	{
		int i = 0;
		while (i < size)
		{
			cout << str[i];
			i++;
		}
		cout << endl;
	}
};