#pragma once
#include "Figure.h"
const double PI = 3.141592653589793238463;

class Circle :public Figure
{
    double r;
public:
    Circle(double rr)
    {
        r = rr;
    }
    double S() override
    {
        return PI * r * r;
    }
    double P() override
    {
        return PI * 2 * r;
    }
};