#include <iostream>
using namespace std;
int main()
{
	setlocale(0, "");
	int b;
	cout<<"Введите размер файла в байтах:";
	cin>>b;
	cout<<"Количство килобайтов в файле:"<<b / 1024;
	return 0;
}