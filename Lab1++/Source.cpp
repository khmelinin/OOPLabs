#include <iostream>
#include <string>

using namespace std;

void PlusOne(int& a)
{
    for (int i = 1; ((a ^= i) & i) == 0; i <<= 1);
}

int main()
{
    int a = -43;
    PlusOne(a);
    cout << a << endl;

}