#include<iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	float x, y;
	cout << "Введите x: ";
	cin >> x;
	y = 4 * pow(x - 3, 6) - 7 * pow(x - 3, 3) + 2;
	cout << y;
	return 0;
}