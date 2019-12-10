#include <iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	float v1, v2, s, t;
	cout << "Введите скорость 1-ого автомобиля:";
	cin >> v1;
	cout << "Введите скорость 2-ого автомобиля:";
	cin >> v2;
	cout << "Введите расстояние между автомобилями:";
	cin >> s;
	cout << "Введите время в часах:";
	cin >> t;
	cout << "Расстояние между автомобилями через :" << t << " часов =" << (v1 * t) + (v2 * t) + s;
	return 0;
}