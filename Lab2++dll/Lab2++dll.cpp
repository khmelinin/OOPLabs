// Lab2++dll.cpp : Defines the exported functions for the DLL.
//

#include "pch.h"
#include "framework.h"
#include "Lab2++dll.h"


// This is an example of an exported variable
LAB2DLL_API int nLab2dll=0;

// This is an example of an exported function.
LAB2DLL_API int fnLab2dll(void)
{
    return 0;
}

// This is the constructor of a class that has been exported.
CLab2dll::CLab2dll()
{
    return;
}
