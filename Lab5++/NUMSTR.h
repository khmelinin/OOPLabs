#pragma once
#include "STR.h"
#include <string>

class NUMSTR:public STR
{
public:
	NUMSTR(int n)
	{
		string tmp = to_string(n);
		str = new char[tmp.size];
		for (int i = 0; i < tmp.size(); i++)
		{
			str[i] = tmp[i];
		}
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
};