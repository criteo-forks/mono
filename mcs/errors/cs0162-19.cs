// CS0162: Unreachable code detected
// Line: 12
// Compiler options: -warnaserror

public class X
{
	static void test (int stop)
	{
		int pos = 0;
		do {
			break;
		} while (pos < stop);
	}
}
