#include <iostream>
#include <string>

using namespace std;

void PlusOne(int& a)
{
    for (int i = 1; ((a ^= i) & i) == 0; i <<= 1);
}

bool Camparing(int a, int b)
{
    return a & b;
}

int main()
{
    int a = -43;
    int b = 75;
    PlusOne(a);

    cout << a << endl;
    cout << "Camparing = " << Camparing(a, b) << endl;
}