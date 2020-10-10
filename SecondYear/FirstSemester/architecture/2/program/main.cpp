#include <iostream>
#include <cmath>
#include "fact.h"

using namespace std;
int n;
int y;
long double a;
long double y_pow;

int main() {
    cout << "Enter n: ";
    cin >> n;
    cout << "Enter y: ";
    cin >> y;
    int i = 1;
    while (true){
        a = custom_pow(10, i) / fact(i);
        y_pow = custom_pow(10, y);
        cout << i << ".  a = " << a << endl;
        if (abs(a) < y_pow){
            cout << "a < " << y_pow << endl;
            break;
        }
        i++;
    }
    return 0;
}


