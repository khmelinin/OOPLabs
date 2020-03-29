#include "Str1.h"

Str1::Str1(const char s[])
{
	size = strlen(s)+1;
	str = new char[size];
	for (int i = 0; i < size; i++)
	{
		str[i] = s[i];
	}
}
