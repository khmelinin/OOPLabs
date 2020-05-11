#pragma once
#include <iostream>
#include <string>
#include <vector>

using namespace std;
void (* ClearHandler)(string message);


void DisplayMessage(string message)
    {
        cout << message << endl;
    }

class MyList
{
    vector<string> l;
    
public: 

    MyList(string s)
    {
        l.push_back(s);
    }
    
    void Clear()
    {
        ClearHandler = DisplayMessage;
        ClearHandler("Clear()");
        l.clear();

    }
    
};

