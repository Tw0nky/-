#include <iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	float sr, a, b;
	cout << "Введите первое число= ";
	 cin >> a;
	cout << "Введите второе число= ";
	 cin >> b;
	sr = (a + b) / 2;
	cout << "Среднее арфиметическое= "<<sr<<endl;
	return 0;
}