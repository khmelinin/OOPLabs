#include "Str.h"
using namespace std;

int main()
{
	Str b;
	Str a("hello");
	a.Del("o");
	a.print();
}