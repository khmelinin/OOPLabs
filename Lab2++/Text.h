#pragma once
#include "Str.h"
using namespace std;

class Text
{
	int size = 0;
	Str *text=nullptr;
public:
	Text() = default;
	Text(Str a);
	~Text();
	void Add(Str a);
	void Del();
	void Clear();
	Str Biggest();
	int Elements()const;
	double NumbersPectentage()const;
};