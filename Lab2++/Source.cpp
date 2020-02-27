#include "Text.h"
using namespace std;

int main()
{
	char b[] = { "ll" };
	Str a("hell45180o");
	Str aa("world123");
	Text t(a);
	t.Add(aa);

	int e = t.Elements();
	double n = t.NumbersPectentage();

	system("pause");

}