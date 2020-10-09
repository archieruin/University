#include <iostream>
using namespace std;
#define m 95

int main() {
	short A, B, C1, D, X;
	cout << "Enter a="; cin >> A;
	cout << "Enter b="; cin >> B;
	cout << "Enter c="; cin >> C1;
	cout << "Enter d="; cin >> D;

	__asm {
		xor eax, eax							//; ax = 0
		mov      ax, B      					//; ax = b
		mul      ax								//; ax = b ^ 2
		mov      cx, ax							//; cx = ax = b ^ 2
												//
		xor eax, eax							//; ax = 0
		mov      ax, C1   				    	//; ax = c
		mul      ax								//; ax = c ^ 2
		mul      cx								//; ax = c ^ 2 * b ^ 2
		sub      ax, 23d						//; ax = (c ^ 2 * b ^ 2) - 23
		mov      cx, ax							//; cx = ax = (c ^ 2 * b ^ 2) - 23
												//
		xor eax, eax							//; ax = 0
		mov      ax, D                          //; ax = d
		mul      ax; ax = d ^ 2					//
		sub      ax, B       					//; ax = d ^ 2 - b
		mov      bx, A			        		//; bx = a
		mul      bx								//; dx:ax = (d ^ 2 - b) * a
		div      cx								//; ax = (d ^ 2 - b) * a / (c ^ 2 * b ^ 2) - 23
		mov      cx, ax							//; cx = ax = (d ^ 2 - b) * a / (c ^ 2 * b ^ 2) - 23 --->cx
												//
		xor eax, eax							//; ax = 0
		mov      bx, B          				//; bx = b
		add      bx, cx							//; bx = b + ((d ^ 2 - b) * a / (c ^ 2 * b ^ 2) - 23)
		sub      bx, 95d						//; bx = b + ((d ^ 2 - b) * a / (c ^ 2 * b ^ 2) - 23) - 95

		mov[X], bx
	}

	cout << "Result: " << X << endl;
	return 0;
}
