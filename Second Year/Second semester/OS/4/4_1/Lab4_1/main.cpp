#include <iostream>
using namespace std;
extern "C" int Expression(int, int, int, int);
int main()
{
	int a, b, c, d, x;
	cout << "Enter a="; cin >> a;
	cout << "Enter b="; cin >> b;
	cout << "Enter c="; cin >> c;
	cout << "Enter d="; cin >> d;
	cout << "Result: " << Expression(a, b, c, d) << endl;
	system("pause");
	return 0;
}
