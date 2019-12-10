#include<iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	float x, y;
	cout << "Введите x: ";
	cin >> x;
	y = 3 * pow(x, 6) - 6 * pow(x, 2) - 7;
	cout << y;
	return 0;
}