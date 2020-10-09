#include <iostream>
#include "func.h"

using namespace std;

int sum = 0;
int n;

int main() {
    cout << "Enter n: ";
    cin >> n;
    int *a = new int[n];
    for (int i = 1; i <= n; ++i) {
        cout << "Enter number: ";
        cin >> a[i];
        int mod = custom_mod(abs(a[i]), n);
        if (mod == 0) {
            sum += a[i];
            cout << "Your number (" << a[i] << ") is a multiple of " << n << endl;
        } else
            cout << "Your number (" << a[i] << ") is NOT a multiple of " << n << endl;
    }
    cout << "Sum = " << sum << endl;
    return 0;
}


