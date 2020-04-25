#include "NUMSTR.h"
#include "Trapez.h"
#include "Circle.h"
using namespace std;

int main()
{
	
	NUMSTR n(123);
	NUMSTR mm;
	n.print();
	char* s = n.getStr();
	n.Del('2');
	n.print();

    double tt[4][2] = { { 1, 5 }, { 3, 5 }, { 4, 0 }, { 0, 0 } };
    Trapez t(tt);
    Circle c(4);
	cout << "Trapez S = " << t.S() << endl;
	cout << "Trapez P = " << t.P() << endl;
	cout << "Circle S = " << c.S() << endl;
	cout << "Circle P = " << c.P() << endl;
}