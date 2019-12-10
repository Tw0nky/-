#include <iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	float s, r, p, x,a,b;
	cout << "Введите первое число= "; cin >> a;
	cout << "Введите второе число= "; cin >> b;
	s = abs(a) + abs(b);
	cout << "Сумма= " << s << endl;
	r = abs(a) - abs(b);
	cout << "Разность= " << r << endl;
	p = abs (a) * abs (b);
	cout << "Произведение= " << p << endl;
	x = abs(a) / abs(b);
	cout << "Частное= " << x << endl;
	return 0;
}