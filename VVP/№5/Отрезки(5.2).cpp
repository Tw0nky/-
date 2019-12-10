#include <iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	int a, b;
	cout << "Введит длину отрезка A:";
	cin >> a;
	cout << "Введите длину отрезка B:";
	cin >> b;
	cout << "Количество отрезков B, размещенных на отрезке A = " << a / b;
 return 0;
}