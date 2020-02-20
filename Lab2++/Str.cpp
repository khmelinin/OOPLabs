#include "Str.h"

Str::Str(string s)
{
	str = s;
}

string Str::getStr() const
{
	return str;
}

void Str::setStr(string str)
{
	this->str = str;
}
