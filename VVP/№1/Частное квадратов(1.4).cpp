#include <iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	int a, b;
	float s, r, p, x;
	cout << "Введите первое число= "; cin >> a;
	cout << "Введите второе число= "; cin >> b;
	s = a*a + b*b;
	cout << "Сумма= " << s << endl;
	r = a*a - b*b;
	cout << "Разность= " << r << endl;
	p = (a * a)*(b * b);
	cout << "Произведение= " << p << endl;
	x= (a * a)/(b * b);
	cout << "Частное= " << x << endl;
	return 0;
}