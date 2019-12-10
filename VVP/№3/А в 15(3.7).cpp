#include <iostream>
#include <cmath>
using namespace std;
int main()
{
	setlocale(0, "");
	int a, n, b;
	cout << "Введите число А: ";
	cin >> a;
	b = a * a;
	n = b * a * a * a * pow(a, 10);
	cout << n;
	return 0;
}