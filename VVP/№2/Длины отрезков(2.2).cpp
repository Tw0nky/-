#include <iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	float a, b, c,ac,bc;
	cout << "Введите a,b,c через пробел:";
	cin >>a>>b>>c;
	ac = abs(a - c);
	bc = abs(b - c);
	cout<<"AC="<< ac << " BC=" << bc << " Сумма=" << ac + bc;
	return 0;
}