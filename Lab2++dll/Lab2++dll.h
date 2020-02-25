// The following ifdef block is the standard way of creating macros which make exporting
// from a DLL simpler. All files within this DLL are compiled with the LAB2DLL_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see
// LAB2DLL_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef LAB2DLL_EXPORTS
#define LAB2DLL_API __declspec(dllexport)
#else
#define LAB2DLL_API __declspec(dllimport)
#endif
#include "Text.h"
// This class is exported from the dll
class LAB2DLL_API CLab2dll {
public:
	CLab2dll(void);
	// TODO: add your methods here.
};

extern LAB2DLL_API int nLab2dll;

LAB2DLL_API int fnLab2dll(void);
