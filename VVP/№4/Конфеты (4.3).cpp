#include <iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	float y, k, c;
	cout << "Введите количество килограмм:";
	cin >> k;
	cout << "Введите цену:";
	cin >> c;
	cout << "Цена за килограмм=" << c / k << endl;
	cout << "Введите количество килограмм Y:";
	cin >> y;
	cout << "Цена " << y << " кг" << " = " << y * (c / k) << endl;
}








	