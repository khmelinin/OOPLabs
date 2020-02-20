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

void Str::print()
{
	cout << str << endl;
}

void Str::Add(string s)
{
	str += s;
}

void Str::Del(string s)
{
	str.erase(str.find(s), str.find(s) + s.size());
}
