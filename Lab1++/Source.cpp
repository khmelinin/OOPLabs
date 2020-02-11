#include <iostream>
#include <string>

using namespace std;

void PlusOne(int &a, int &b)
{
	 a=a ^ b;
}

int main()
{
	//int x = 1;
	///*cin >> x;*/
	//if (x < 0)
	//{
	//	x = x * (-1);
	//	cout << "new x = " << x << endl;
	//	cout << "1";
	//	for (int i = sizeof(x) * 8 - 1; i >= 0; --i)
	//	{
	//		if (i != 31)
	//			cout << (int)((x >> i) & 1);
	//	}
	//}
	//if(x>=0)
	//{
	//	for (int i = sizeof(x) * 8 - 1; i >= 0; --i)
	//	{
	//		cout << (int)((x >> i) & 1);
	//	}
	//}
	
	int a = -43, b=1;
	PlusOne(a, b);
	cout << "PlusOne = " << a << endl;

}