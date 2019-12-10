#include <iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	int a, b, c, k, k1;
	cout<<"Введите значение A,B и C через пробел: ";
	cin>>a>>b>>c;
	k1 = a;
	k = b;
	a = k;
	b = c;
	c = k1;
	cout<<"Помененные местами A,B и C :"<<a<<" "<<b<<" "<<c;
	return 0;
}