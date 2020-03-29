#pragma once
#include <iostream>
using namespace std;

class Str
{
	int size = 0;
	char* str = nullptr;
public:
	Str() = default;
	Str(const char *s);
	~Str();
	void print();
	int Find(const char s[]);
	int getSize();
	void setSize(int s);
	

	Str(const Str& obj);
	const Str& operator+(const Str& obj);
};