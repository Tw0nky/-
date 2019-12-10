#include <iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	int g;
	cout << "Введите год:";
	cin >> g;
	if (g % 100 == 0)
		cout << "Это " << g / 100 << " век";
	else cout<<"Это " << g / 100 + 1 << " век";
	return 0;
}