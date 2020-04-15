#include <iostream>

using namespace std;


class STR
{
	int size = 0;
	char* str = nullptr;
public:
	STR() = default;
	STR(int s)
	{
		size = s;
		str = new char[size];
	}
	STR(const char val[])
	{
		size = strlen(val);
		str = new char[size];
		for (int i = 0; i < size; i++)
		{
			str[i] = val[i];
		}
	}

	STR(const CS& obj)
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

	const STR operator+(const CS obj)
	{
		STR result(size + obj.size);
		for (int i = 0; i < result.size; i++)
		{
			if (i < size)
				result.str[i] = str[i];
			else
				result.str[i] = obj.str[i - size];
		}
		return result;
	}

	const STR operator-(const char& c)
	{
		STR result(size-1);
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
	STR cs1("qwerty");
	STR cs2("abc");
	STR cs3("de0f");
	cs3 = cs3 - '0';
	cs1 = cs2 + cs3;
	cs3.print();
	cs1.print();

	system("pause");
}