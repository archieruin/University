#include <iostream>
using namespace std;
const double k = 95, m = 23;
extern "C" double Expression(double, double, double, double, double, double);
int main()
{
	double a, b, c, d;
	cout << "Enter a: "; cin >> a;
	cout << "Enter b: "; cin >> b;
	cout << "Enter c: "; cin >> c;
	cout << "Enter d: "; cin >> d;

	cout << "Result: " << Expression(a, b, c, d, k, m) << endl;
	system("pause");
	return 0;
}
