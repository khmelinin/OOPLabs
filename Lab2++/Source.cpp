#include "Text.h"
using namespace std;

void A()
{
	Str a("hel45180o");
	int res = a.Numbers();
	cout << res << endl;
	a.print();
	Text b(a);
	b.Add(a);
	b.getText(0).print();
	b.Del();
	
	//int k = b.Elements();

}

int main()
{
	
	A();
	system("pause");

}