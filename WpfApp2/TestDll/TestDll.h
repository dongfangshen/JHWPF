// ���� ifdef ���Ǵ���ʹ�� DLL �������򵥵�
// ��ı�׼�������� DLL �е������ļ��������������϶���� TESTDLL_EXPORTS
// ���ű���ġ���ʹ�ô� DLL ��
// �κ�������Ŀ�ϲ�Ӧ����˷��š�������Դ�ļ��а������ļ����κ�������Ŀ���Ὣ
// TESTDLL_API ������Ϊ�Ǵ� DLL ����ģ����� DLL ���ô˺궨���
// ������Ϊ�Ǳ������ġ�
#ifdef TESTDLL_EXPORTS
#define TESTDLL_API __declspec(dllexport)
#else
#define TESTDLL_API __declspec(dllimport)
#endif


class TESTDLL_API TestCard {
public:
	TestCard(void);

	int __stdcall Add(int a, int b);

	// TODO: add your methods here.
};

EXTERN_C TESTDLL_API int __stdcall fnTestDll(int a,int b);

EXTERN_C TESTDLL_API TestCard* __stdcall pTest();

EXTERN_C TESTDLL_API int __stdcall AddNew(TestCard* test, int a, int b);


