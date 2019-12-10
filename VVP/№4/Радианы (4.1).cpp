#include <iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	float a;
	cout << "Введите угол а в грудусах:";
	cin >> a;
	cout << "Угол а в радианах= " << (a * 3.14) / 180;
		return 0;
}