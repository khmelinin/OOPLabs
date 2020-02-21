#include "Text.h"
using namespace std;

int main()
{
	char b[] = { "ll" };
	Str a("hello");
	Str aa("world 333");
	Text t(a);
	t.Add(aa);

	int e = t.Elements();
	int n = t.NumbersPectentage();
	
}