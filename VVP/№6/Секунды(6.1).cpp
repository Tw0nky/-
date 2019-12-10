#include <iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	int a;
	cout << "Введите количество секунд:";
	cin >> a;
	cout << "Количество секунд, прошедших с начала последней минуты = " << a % 60;
	return 0;
}