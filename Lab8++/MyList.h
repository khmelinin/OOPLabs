#pragma once
#include <iostream>
#include <vector>
#include <string>
class MyList
{
    vector<string> l;
public: 
    //delegate void ClearHandler(string message);
    //event ClearHandler Notify = DisplayMessage;
    
    MyList(string[] s)
    {
        l = new List<string>(s);
    }
    void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }
    delegate void clear();
    clear Clear = () = > { l.Clear(); Notify ? .Invoke($"Clear()"); };

    List<string> L{ get = > l; set = > l = value; }
};

