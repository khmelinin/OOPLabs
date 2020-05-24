#pragma once
#include "Node.h"
#include <iostream>

class MyCollection
{
    Node* head = nullptr;
    Node* tail = nullptr;
    int count = 0;

public:
    MyCollection(char data)
    {
        Push(data);
    }

    MyCollection(const char data[])
    {
        for (int i = 0; i < strlen(data); i++)
        {
            Push(data[i]);
        }
    }

    int getCount() { return count; }
    bool IsEmpty() { return count == 0; }


    void Push(char data)
    {
        Node* tmp = new Node(data);
        if (head == nullptr)
        {
            head = tmp;
        }
        else
        {
            tail->Next = tmp;
        }
        tail = tmp;
        count++;

    }

    bool Contains(char data)
    {
        Node* current = head;
        while (current != nullptr)
        {
            if (current->Data==data)
                return true;
            current = current->Next;
        }
        return false;
    }
    int FindCount(char data)
    {
        Node* current = head;
        int tmp = 0;
        while (current != nullptr)
        {
            if (current->Data==data)
                tmp++;
            current = current->Next;
        }
        return tmp;
    }
    void DelAfter(char data)
    {
        Node* current = head;
        int tmp = 0;
        while (current != nullptr)
        {
            tmp++;
            if (current->Data==data)
            {
                current->Next = nullptr;
                count = tmp;
            }
            current = current->Next;
        }
    }
};

