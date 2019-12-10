#include <iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	int a,b;
	cout << "Введите двузначное число:";
	cin >> a;
	cout << "Число полученное после перестановки:" << (a % 10 * 10) + a / 10;
	return 0;
}