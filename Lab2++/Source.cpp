#include "Str.h"
using namespace std;

int main()
{
	char b[] = { "ll" };
	Str a("hello");
	a.Del(b);
	a.print();
}