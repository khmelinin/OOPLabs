#include <iostream>

using namespace std;


class CS
{
	int size = 0;
	char* str = nullptr;
public:
	CS() = default;
	CS(int s)
	{
		size = s;
		str = new char[size];
	}
	CS(const char val[])
	{
		size = strlen(val);
		str = new char[size];
		for (int i = 0; i < size; i++)
		{
			str[i] = val[i];
		}
	}

	CS(const CS& obj)
	{
		size = obj.size;
		str = new char[size];
		for (int i = 0; i < size; i++)
		{
			str[i] = obj.str[i];
		}
	}
	int getSize() { return size; }
	void setSize(int s) { size = s; }
	const char getCS(int i) { return str[i]; }
	void setCS(int i, const char a) { str[i] = a; }

	const CS operator+(const CS obj)
	{
		CS result(size + obj.size);
		for (int i = 0; i < result.size; i++)
		{
			if (i < size)
				result.str[i] = str[i];
			else
				result.str[i] = obj.str[i - size];
		}
		return result;
	}

	const CS operator-(const char& c)
	{
		CS result(size-1);
		int i = 0;
		while (str[i] != c && i < result.getSize())
		{
			result.str[i] = str[i];
			i++;
		}
		for (int j = i + 1; j < result.getSize() + 1; j++)
		{
			result.str[j - 1] = str[j];
		}
		return result;
	}

	void print()
	{
		cout << size << endl;
		for (int i = 0; i < size; i++)
		{
			cout << str[i];
		}
		cout << endl;
	}
};



int main()
{
	CS cs1("qwer");
	CS cs2("tyui");
	CS cs3(cs1 -'w');
	cs3.print();
	system("pause");
}