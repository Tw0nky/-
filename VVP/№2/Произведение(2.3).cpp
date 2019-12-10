#include <iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	int a, b, c, ac, bc, p;
	cout<<"Введите a,b,c через пробел:";
	cin>>a >> b >> c;
	ac = abs(a - c);
	bc = abs(c - b);
	p = ac * bc;
	cout<<"Произведение AC*BC="<<p;
	return 0;
}
