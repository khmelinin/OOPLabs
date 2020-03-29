#include "Str.h"
using namespace std;

Str::~Str()
{
	size = 0;
	delete[]str;
}


Str::Str(const char *s)
{
	size = strlen(s);
	int ssize = size;
	//cout << "strlen(s) = " << size << endl;
	str = new char [size];
	for (int i = 0; i < size; i++)
	{
		str[i] = s[i];
		
	}
}


void Str::print()
{
	for (int i = 0; i < size; i++)
	{
		cout << str[i];
	}
	cout << endl;
}
//------------------------------------------------------------------------
int Str::Find(const char s[])
{
	int k = 0;
	int index=-1;
	int SSize = strlen(s);
	for (int i = 0; i < size; i++)

	{
		if (str[i] == s[0])
		{
			for (int j = 0; j < strlen(s) + 1; j++)
			{
				if (str[i] == s[j])
					k++;
			}
		}
		if (k == strlen(s))
		{
			index = i;
			return index;
		}
	}
	return index;
}

int Str::getSize()
{
	return size;
}
void Str::setSize(int s)
{
	size = s;
}


Str::Str(const Str& obj)
{
	size = obj.size;
	str = new char[size];
	for (int i = 0; i < size; i++)
	{
		str[i] = obj.str[i];
	}
}

const Str& Str::operator+(const Str& obj)
{
	Str tmp(*this);
	int s = tmp.size;
	tmp.size += obj.size;
	for (int i = s; i < tmp.size; i++)
	{
		tmp.str[i] = obj.str[i - obj.size];
	}
	return tmp;
}
