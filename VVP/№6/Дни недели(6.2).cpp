#include <iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	int k;
	cout << "Введите день года:";
	cin >> k;
	cout << "Номер дня недели = "<<k%7;
	return 0;
}