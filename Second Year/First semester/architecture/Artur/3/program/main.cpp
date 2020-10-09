#include <iostream>

using namespace std;

int c_mod(int a, int b){
    while(a - b >= 0) {
        a -= b;
    }
    return a;
}

int main() {
    int dob = 0;
    int n, p;
    cout << "Enter n: ";
    cin >> n;
    cout << "Enter p: ";
    cin >> p;
    int *a = new int[n];
    for (int i = 1; i <= n; ++i) {
        cout << "Enter number: ";
        cin >> a[i];
        int mod = c_mod(abs(a[i]), p);
        if (mod == 0) {
            dob *= a[i];
            cout << "Number (" << a[i] << ") is a multiple of " << n << endl;
        } else
            cout << "Number (" << a[i] << ") is not a multiple of " << n << endl;
    }
    cout << "Dobutok = " << dob << endl;
    return 0;
}
