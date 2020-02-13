#include <iostream>
#include <string>

using namespace std;

void PlusOne(int& a);
bool Comparing(int a, int b);

int main()
{
    int a = -43, aa = 75, aaa = 63;
    int b = 48,  bb = 69, bbb = 24;
    int c = 48,  cc = 78, ccc = 25;

    PlusOne(a);
    PlusOne(aa);
    PlusOne(aaa);

    bool ComparingBC = Comparing(b, c);
    bool ComparingBBCC = Comparing(bb, cc);
    bool ComparingBBBCCC = Comparing(bbb, ccc);

    cout << "b=c - " << ComparingBBBCCC << endl;
    cout << (3 ^ 9) << endl;

}

void PlusOne(int& a)
{
    int i = 1;
    for (int i = 1; ((a ^= i) & i) == 0; i <<= 1);
    int ok;
    ok = a;
  /*  while ((a ^= i) & i == 0)
    {
        i <<= 1;
    }*/
}

bool Comparing(int a, int b)
{
    int aa, bb, ii;
    for (int i = sizeof(a)*8; i > 0; i--)
    {
        ii = 1 >> i;
        aa = a & ii;
        bb = b & ii;
        if(aa^bb)
        {
            bool ok = 0;
            return 0;
        }
    }
    bool ok = 1;
    return 1;
    /*return (a ^ b) == 0;*/
}