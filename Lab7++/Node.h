#pragma once
struct Node
{
	char Data;
	Node* Next = nullptr;
	Node(char data)
	{
		Data = data;
	}
	Node() = default;
	
};

