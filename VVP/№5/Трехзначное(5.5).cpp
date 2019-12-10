#include <iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	int a, b;
	cout << "Введите трехзначное число:";
	cin >> a;
	cout << "Число после преобразования:" << a % 100 * 10 + a / 100;
	return 0;
}