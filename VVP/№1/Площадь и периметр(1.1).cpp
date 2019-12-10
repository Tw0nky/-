#include <iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	int a, b,S,P;
	cout << "Введите первое число= ";
	cin >> a;
	cout << "Введите второе число= ";
	cin >> b;
	 S = a * b;
	 P = 2 * (a + b);
	 cout << "Площадь = " << S << endl;
	 cout << "Периметр = " << P << endl;
	return 0;
}

