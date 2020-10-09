#include <iostream>
#include <cmath>

using namespace std;
int n;
int y;
long double sum = 0;
long double a;
long double y_pow;


long double fact(int N)
{
    if(N < 0)
        return 0;
    if (N == 0)
        return 1;
    else
        return N * fact(N - 1);
}

int main() {
    cout << "Enter i: ";
    cin >> n;
    cout << "Enter y: ";
    cin >> y;
    int i = 1;
    while (true){
        a = fact(i) / (3 * pow(i, i));
        sum += a;
        y_pow = pow(10, y);
        cout << i << ".  a = " << a << endl;
        if (abs(a) < y_pow){
            cout << "a < " << y_pow << endl;
            break;
        }
        i++;
    }
    cout << "Sum = " << sum << endl;
    return 0;
}


