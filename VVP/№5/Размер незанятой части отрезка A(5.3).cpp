#include <iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	int a, b;
	cout << "Введите размер отрезка A:";
		cin >> a;
		cout << "Введите размер отрезка B:";
		cin >> b;
		cout << "Длину незанятой части отрезка A = " << a % b;
	return 0;
}

