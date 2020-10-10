#include <iostream>

using namespace std;

int main() {
    int x, y;
    do{
        cout << "Enter x: ";
        cin >> x;
        cout << "Enter y: ";
        cin >> y;
        if (x == y)
            cout << "X must be not equals Y !!!\n";
    } while(x == y);
    if (x > y) {
        y = (x + y) / 2;
        x = (x * y) * 2;
    } else {
        x = (x + y) / 2;
        y = (x * y) * 2;
    }
    cout << "x = " << x << endl;
    cout << "y = " << y << endl;
    return 0;
}




