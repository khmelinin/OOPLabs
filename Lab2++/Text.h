#pragma once
#include "Str.h"
class Text
{
	int size = 0;
	Str *text=nullptr;
public:
	Text() = default;
	Text(Str a);
	void Add(Str a);
	void Del();
	void Clear();
	Str Biggest();
	int Elements();
	int NumbersPectentage()const;
	
};

