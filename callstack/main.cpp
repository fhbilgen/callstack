#include <Windows.h>
#include <stdio.h>


int fonksiyon1(int r);
int fonksiyon2(int q);
int fonksiyon3(int z);
int fonksiyon4(int y);
int fonksiyon5(int x);

int fonksiyon1(int r)
{
	return fonksiyon2(r);
}

int fonksiyon2(int q)
{
	return 2 * fonksiyon3(q);
}

int fonksiyon3(int z)
{
	return 3 * fonksiyon4(z);
}

int fonksiyon4(int y)
{
	return 4 * fonksiyon5(y);
}

int fonksiyon5(int x)
{
	DebugBreak();
	return x * 5;
}



int main(int argc, void* arg)
{
	int i = 10;
	int j = 0;
	int z = 0;

	printf("basla\n");
	scanf_s("%i", &z);

	j = fonksiyon1(i);
	printf("Sonuc: %i\n", j);

	return 0;
}