#include <iostream>
using namespace std;

int main() {
	double A, B, C1, D, M = 95, K = 23, X;
	cout << "Enter a="; cin >> A;
	cout << "Enter b="; cin >> B;
	cout << "Enter c="; cin >> C1;
	cout << "Enter d="; cin >> D;

	__asm {
		finit

		fld B						// st(0) = b
		fmul st(0), st(0)			// st(0) = b ^ 2

		fld K						// st(0) = 23
		fld C1						// st(0) = c
		fmul st(0), st(0)			// st(0) = c ^ 2
		fmul st(0), st(2)			// st(0) = c ^ 2 * b ^ 2
		fsub st(0), st(1)			// st(0) = (c ^ 2 * b ^ 2) - 23

		fld D						// st(0) = d
		fmul st(0), st(0)			// st(0) = d ^ 2
		fsub B			            // st(0) = d ^ 2 - b

		fld A						// st(0) = a
		fmul st(0), st(1)			// st(0) = a * (d ^ 2 - b)
		fdiv st(0), st(2)			// st(0) = a * (d ^ 2 - b) / (c ^ 2 * b ^ 2) - 23
		
		fld B						// st(0) = b
		fsub M		            	// st(0) = b - 95

		fadd st(0), st(1)			// st(0) = (a * (d ^ 2 - b) / (c ^ 2 * b ^ 2) - 23) + (b - 95)

		fst X
	}

	cout << "Result: " << X << endl;
	system("pause");
	return 0;
}
