#include <iostream>
#include <string>

using namespace std;

void PlusOne(int& a)
{
    for (int i = 1; ((a ^= i) & i) == 0; i <<= 1);
}

bool Comparing(int a, int b)
{
    return (a ^ b) == 0;
}

int main()
{
    int a = -43;
    int b = 75;
    PlusOne(a);

    cout << a << endl;
    cout << "Camparing = " << Comparing(a, b) << endl;
}