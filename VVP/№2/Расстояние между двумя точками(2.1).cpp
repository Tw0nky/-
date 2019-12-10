#include <iostream>
#include <cmath>
using namespace std;
int main()
{
	setlocale(0,"");
		double x1,y1,x2,y2,r;
	cout << "Введите координаты первой точки x1=";
	cin >> x1;
	cout << "Введите координаты первой точки y1=";
	cin >> y1;
	cout << "Введите координаты второй точки x2=";
	cin >> x2;
	cout << "Введите координаты второй точки y2=";
	cin >> y2;
	cout << "Расстояние между двумя точками с заданными координатами= " << sqrt(pow((x2 - x1), 2) + pow((y2 - y1),2));
	return 0;
}