#include <iostream>
#include <cmath>
using namespace std;
int main()
{
	setlocale(0, "");
	int a, n;
	cout << "Введите число А: ";
	cin >> a;
	n = a * a * a * pow(a, 5);
	cout << n;
	return 0;
}