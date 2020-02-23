#pragma once
#include "Str.h"
class Text
{
	int size = 0;
	Str *text=nullptr;
public:
	Text() = default;
	~Text();
	Text(Str a);
	void Add(Str a);
	void Del();
	void Clear();
	//void Replace(const char s, const char ss);
	Str Biggest();
	int Elements()const;
	double NumbersPectentage()const;
};