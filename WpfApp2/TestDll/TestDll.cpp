// TestDll.cpp : ���� DLL Ӧ�ó���ĵ���������
//

#include "stdafx.h"
#include "TestDll.h"



// ���ǵ���������һ��ʾ����
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