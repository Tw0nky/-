#include <iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	int a, b, k;
	cout << "Введите значение A и B через пробел: ";
	cin >> a >> b;
	k = a;
	a = b;
	b = k;
	cout << "Поменянные местами A и B: " << a << " " << b;
	return 0;
}