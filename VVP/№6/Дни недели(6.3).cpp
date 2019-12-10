#include <iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	int k, n;
	cout << "Введите день года:";
	cin >> k;
	cout << "Введите номер недели когда было 1 января:";
	cin >> n;
	cout << "Номер дня недели = " <<(k+n)%7-1 ;
	return 0;
}