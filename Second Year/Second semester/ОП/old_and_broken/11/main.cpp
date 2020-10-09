#include <iostream>

using namespace std;

int main() {
    int n, m, x;

    cout << "Введите n: ";
    cin >> n;
    cout << "Введите m: ";
    cin >> m;
    cout << "Введите x: ";
    cin >> x;
    int matrix[n][m];

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            cout << "Введите елемент матрици [" << i << "][" << j << "]: ";
            cin >> matrix[i][j];
        }
    }

    cout << endl;
    cout << "Більші за x, елементи та їхні індекси:" << endl;
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            if (matrix[i][j] > x) {
                cout << "[" << i << "][" << j << "] = " << matrix[i][j] << endl;
            }
        }
    }

    return 0;
}
