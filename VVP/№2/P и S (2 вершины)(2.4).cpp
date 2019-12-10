#include <iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	int x1, x2, y1, y2, p, s, a, b;
	cout<<"Введите x1,y1,x2,y2 через пробел:";
	cin>>x1>>y1>>x2>>y2;
	a = abs(x2 - x1);
	b = abs(y2 - y1);
	s = a * b;
	p = 2 * (a + b);
	cout<<"Периметр="<<p<<" Площадь="<<s;
	return 0;
}