#include <iostream>
#include "math.h"

using namespace std;

class Expression
{
    double a;
    double b;
    double c;
public:
    Expression(int aa, int bb, int cc)
    {
        a = aa;
        b = bb;
        c = cc;
    }
    double getA() { return a; }
    double getB() { return b; }
    double getC() { return c; }

    void setA(int x) { a=x; }
    void setB(int x) { b=x; }
    void setC(int x) { c=x; }

    double Result()
    {
        double res = 0;

        res = Dividing((8 * Log10(b - 1) - c), (a * 2 + Dividing(b, c)));

        return res;
    }

    double Log10(double a)
    {
        double res = 0;
        try
        {
            if (a <= 0)
                throw runtime_error("Log10 Error");
            res = log10(a);
        }
        catch (runtime_error e)
        {
            cout << e.what() << endl;
        }
        return res;
    }

    double Dividing(double a, double b)
    {
        double res = 0;

        try
        {
            if (b == 0)
                throw runtime_error("dividing by zero");
            res = a / b;
        }
        catch (runtime_error e)
        {
            cout << e.what() << endl;
        }
        return res;
    }

    double operator /(double b)
    {
        double res = 0;

        try
        {
            if (b == 0)
                throw runtime_error("dividing by zero (operator)");
            res = a / b;
        }
        catch (runtime_error e)
        {
            cout << e.what() << endl;
        }
        return res;
    }
};

int main()
{
    Expression a[] = { Expression(1,1,1), Expression(1,2,0), Expression(1,1,0) };

    cout << "a[0].Result() = " << a[0].Result() <<  endl;
    cout << "a[1].Result() = " << a[1].Result() <<  endl;
    cout << "a[2].Result() = " << a[2].Result() <<  endl;

    double d = a[0] / 0;
    cout << d << endl;
}

