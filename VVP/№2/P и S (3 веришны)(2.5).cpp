#include <iostream>
#include <cmath>
using namespace std;
int main()
{setlocale(0, "");
int x1, x2, x3, y1, y2, y3;
cout << "Введите через пробел x1,y1,x2,y2,x3,y3:";
cin >> x1 >> y1 >> x2 >> y2 >> x3 >> y3;
float x, y, z, s, p;
x=sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2));
y=sqrt(pow(x3 - x2, 2) + pow(y3 - y2, 2));
z=sqrt(pow(x3 - x1, 2) + pow(y3 - y1, 2));
p = (x + y + z) / 2; 
s = sqrt(p * (p - x) * (p - y) * (p - z));
cout << "Площадь= " << s << " Периметр= " << p*2;
	return 0;
}