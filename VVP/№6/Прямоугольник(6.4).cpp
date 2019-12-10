#include <iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	int a, b, c,s,n;
	cout << "Введите A,B и С через пробел:";
	cin >> a >> b >> c;
	n = (a / c) * (b / c);
	s = a * b - n * pow(c, 2);
	cout << "Количество квадратов со стороной С на прямоугольнике = " << n << endl;
	cout << "Площадь незанятой части прямоугольника = " << s;
	return 0;
}