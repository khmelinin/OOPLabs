#pragma once
#include "Figure.h"
class Trapez :Figure
{
    double v[4][2]= { { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 } };
    double ab, bc, cd, da, h;
public:
    Trapez(double vv[4][2])
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                v[i][j] = vv[i][j];
            }
        }
        ab = sqrt((v[1][0] - v[0][0]) * (v[1][0] - v[0][0]) + (v[1][1] - v[0][1]) * (v[1][1] - v[0][1]));
        bc = sqrt((v[2][0] - v[1][0]) * (v[2][0] - v[1][0]) + (v[2][1] - v[1][1]) * (v[2][1] - v[1][1]));
        cd = sqrt((v[3][0] - v[2][0]) * (v[3][0] - v[2][0]) + (v[3][1] - v[2][1]) * (v[3][1] - v[2][1]));
        da = sqrt((v[0][0] - v[3][0]) * (v[0][0] - v[3][0]) + (v[0][1] - v[3][1]) * (v[0][1] - v[3][1]));

        h = v[1][1] - v[3][1];
    }
    double S()override
    {
        return (ab + cd) / 2 * h;
    }
    double P()override
    {
        return ab + bc + cd + da;
    }
};

