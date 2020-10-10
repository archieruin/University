#include <iostream>

using namespace std;

int main() {
    int x, y;
    do{
        cout << "Enter x: ";
        cin >> x;
        cout << "Enter y: ";
        cin >> y;
    } while(x == y);
    if (x + y < 1){
        x = abs(x);
        y = abs(y);
    } else {
        cout << pow(x - y, 2) << endl;
    }
    return 0;
}



