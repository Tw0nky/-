#include <iostream>
using namespace std;
int main()
{   
	setlocale(0, "");
	float a,b;
	cout << "Ввведите A и B через пробел:";
	cin >> a >> b;
	cout << "Уравнение вида A·x + B = 0 равно " << (-1 * b)/a;
	return 0;
}