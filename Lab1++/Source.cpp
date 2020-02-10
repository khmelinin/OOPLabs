#include <iostream>

using namespace std;

int main() 
{


	int x = 148;
	/*cin >> x;*/
	for (i = sizeof(x) * 8 - 1; i >= 0; --i)
	{
		cout << (int)((x >> i) & 1);
	}
}