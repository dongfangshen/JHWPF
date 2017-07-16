// TestDll.cpp : 定义 DLL 应用程序的导出函数。
//

#include "stdafx.h"
#include "TestDll.h"



// 这是导出函数的一个示例。
TESTDLL_API int __stdcall fnTestDll(int a,int b)
{
    return a + b;
}

TestCard::TestCard(void)
{}

int TestCard::Add(int a, int b)
{
	return a + b;
}

TESTDLL_API TestCard* __stdcall pTest()
{
	return new TestCard();
}

TESTDLL_API int __stdcall AddNew(TestCard* test,int a,int b)
{
	return 	test->Add(a, b);
}