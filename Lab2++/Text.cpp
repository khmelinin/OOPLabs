#include "Text.h"
using namespace std;

Text::~Text()
{
	size = 0;
	delete[]text;
}

Text::Text(Str a)
{
	size++;
	text = new Str(a);
}

void Text::Add(Str a)
{
	size++;
	text[size] = a;
}

void Text::Del()
{
	delete[size]text;
	size--;
}

void Text::Clear()
{
	*text = nullptr;
	size = 0;
}

Str Text::getText(int i)
{
	return text[i];
}



Str Text::Biggest()
{
	int k = 0, index = 0;
	for (int i = 0; i < size; i++)
	{
		if (text[i].getSize() > k)
		{
			k = text[i].getSize();
			index = i;
		}
	}
	return text[index];
}

int Text::Elements()
{
	int e = 0;
	for (int i = 0; i < size; i++)
	{
		e += text[i].getSize();
	}
	return e;
}

double Text::NumbersPectentage()
{
	int e = Elements();
	int n= 0;
	for (int i = 0; i < size; i++)
	{
		n += text[i].Numbers();
	}
	return 100 * n / e;
}