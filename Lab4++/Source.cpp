#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include "Text.h"
using namespace std;

/*
class CS
{
	int size = 0;
	char* cs = nullptr;
public:
	CS() = default;
	CS(const char val[])
	{
		size = strlen(val);
		cs = new char[size];
		for (int i = 0; i < size; i++)
		{
			cs[i] = val[i];
		}
	}

	CS(const CS& obj)
	{
		size = obj.size;
		cs = new char[size];
		for (int i = 0; i < size; i++)
		{
			cs[i] = obj.cs[i];
		}
	}
	int getSize() { return size; }
	void setSize(int s) { size = s; }
	const char getCS(int i) { return cs[i]; }
	void setCS(int i, const char a) { cs[i] = a; }
	const CS operator+(const CS obj)
	{
		
		int s = size;
		setSize(size + obj.size);
		for (int i = s; i < size; i++)
		{
			cs[i] = obj.cs[i];
		}
		return *this;
	}

	const CS operator-(const char& c)
	{
		CS res;
		res = *this;
		for (int i = 0; i < res.size; i++)
		{
			if (res.cs[i] == c)
			{
				for (int j = i; j < res.size - 1; j++)
				{
					res.cs[j] = res.cs[j + 1];
				}
				size--;
				delete[size]res.cs;
			}
		}
		return res;
	}

	void print()
	{
		for (int i = 0; i < size; i++)
		{
			cout << cs;
		}
		cout << endl;
	}
};
*/


int main()
{
	Str cs1("qwer");
	Str cs2("tyui");
	Str cs3(cs1 + cs2);
	//cs3.print();
	system("pause");
}