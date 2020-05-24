#include "MyCollection.h"
using namespace std;

int main()
{
	MyCollection a("asdf*g#hjk*ghj*");
	cout << a.FindCount('*') << endl;
	a.DelAfter('#');
	cout << a.FindCount('*') << endl;

	system("pause");
}