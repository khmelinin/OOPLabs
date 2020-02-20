#pragma once
#include <iostream>
#include <string>
using namespace std;

class Str
{
	string str;
public:
	Str() = default;
	Str(string s);
	string getStr()const;
	void setStr(string str);
	void print();
	void Add(string s);
	void Del(string s);
};

