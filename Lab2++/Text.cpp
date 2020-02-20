#include "Text.h"

Text::Text(Str a)
{
	size++;
	text = new Str[size];
	text[0] = a;
}

void Text::Add(Str a)
{
	size++;
	text[size - 1] = a;
}

void Text::Del()
{
	delete[size-1]text;
	size--;
}

void Text::Clear()
{
	*text = nullptr;
	size = 0;
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

int Text::NumbersPectentage() const
{
	int n= 0;
	for (int i = 0; i < size; i++)
	{
		n += text[i].Numbers();
	}
	return 100 * n / Elements();
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
