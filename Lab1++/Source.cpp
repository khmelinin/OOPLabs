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
    int a = -43, aa = 75, aaa=63;
    int b = 48, bb = 69, bbb = 24;
    int c = 48, cc = 78, ccc = 25;
    PlusOne(a);
    PlusOne(aa);
    PlusOne(aaa);

    bool ComparingBC = Comparing(b, c);
    bool ComparingBBCC = Comparing(bb, cc);
    bool ComparingBBBCCC = Comparing(bbb, ccc);

    cout << a << endl;
    cout << "Camparing = " << Comparing(b, c) << endl;
}