#pragma once
#include <cstdlib>
#include <iostream>
using namespace std;


class STR
{
protected:
	int size = 0;
	char* str = nullptr;
public:
	STR() = default;
	STR(const char val[])
	{
		size = strlen(val);
		str = new char[size];
		for (int i = 0; i < size; i++)
		{
			str[i] = val[i];
		}
	}

	STR(char* val)
	{
		str = val;
	}

	int getSize()
	{
		return size;
	}

	void print()
	{
		for (int i = 0; i < size; i++)
		{
			cout << str[i];
		}
		cout << endl;
	}
};