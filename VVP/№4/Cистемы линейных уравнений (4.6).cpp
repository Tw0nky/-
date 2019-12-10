#include <iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	int a1, a2, b1, b2, c1, c2, d, x, y;
	cout << "Введите A1:";
	cin >> a1;
	cout << "Введите B1:";
	cin >> b1;
	cout << "Введите C1:";
	cin >> c1;
	cout << "Введите A2:";
	cin >> a2;
	cout << "Введите B2:";
	cin >> b2;
	cout << "Введите C2:";
	cin >> c2;
	d = a1 * b2 - a2 * b1;
	x = (c1 * b2 - c2 * b1) / d;
	y = (a1 * c2 - a2 * c1) / d;
	cout << "X = " << x << endl << "Y = " << y;
	return 0;
}
