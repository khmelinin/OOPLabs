#pragma once
#include <iostream>
using namespace std;

class Str1
{
	int size = 0;
	char* str = nullptr;
public:
	Str1() = default;
	Str1(const char s[]);
};

