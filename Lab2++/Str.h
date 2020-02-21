#pragma once
#include <iostream>
#include <string>
using namespace std;

class Str
{
	int size = 0;
	char* str = nullptr;;
public:
	Str() = default;
	~Str();
	Str(const char s[]);
	void print();
	int Find(const char s[]);
	void Add(const char s[]);
	void Del(const char s[]);
	int getSize()const;
	int Numbers()const;
};

