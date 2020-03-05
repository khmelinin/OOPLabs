#include "Str.h"
using namespace std;

Str::~Str()
{
	size = 0;
	delete[]str;
}


Str::Str(const char s[])
{
	size = strlen(s);
	int ssize = size;
	cout << "strlen(s) = " << size << endl;
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
//------------------------------------------------------------------------
void Str::Add(const char s[])
{
	int j = size;
	size += strlen(s);
	for (int i = j; i < size; i++)
	{
		str[i] = s[i - j];
	}
}

void Str::Del(const char s[])
{
	int ii = size - strlen(s);
	for (int i = Find(s); i < ii; i++)
	{
		str[i] = str[i + strlen(s)];
	}
	size -= (strlen(s));
}

int Str::getSize()
{
	return size;
}
//--------------------------------------------------
int Str::Numbers()
{
	int n = 0;

	for (int i = 0; i < size; i++)
	{
		if (str[i] >= 48 && str[i] <= 57)
			n++;
	}

	return n;
}
