#pragma once
#include <iostream>
#include "Text.h"
using namespace std;

class Str1
{
	int size = 0;
	char* str = nullptr;
public:
	Str1() = default;
	Str1(const char s[]);
};

