#pragma once
#include <iostream>
using namespace std;

class Str
{
	int size = 0;
	char* str = nullptr;
public:
	Str() = default;
	~Str();
	Str(const char s[]);
	void print();
	int Find(const char s[]);
	void Add(const char s[]);
	void Del(const char s[]);
	//bool Replace(const char s, const char ss);
	int getSize()const;
	int Numbers()const;
};