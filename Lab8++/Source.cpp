#include <iostream>
#include <string>
#include "MyList.h"

using namespace std;

bool Function(const char str[])
{
    int n = 0, s = 0;
    for (int i = 0; i < strlen(str); i++)
    {
        if (str[i] >= 67 && str[i] <= 90 || str[i] >= 97 && str[i] <= 122)
        {
            s++;
        }
        else if (str[i] >= 48 && str[i] <= 57)
        {
            n++;
        }
    }
    if (s > n)
        return 1;
    else
        return 0;
}

bool (*F)(const char str[]);

int main()
{
    F = Function;
    cout << F("dasqwads123324dsasdsa") << endl;
    MyList mylist ("adsad");
    mylist.Clear();
}