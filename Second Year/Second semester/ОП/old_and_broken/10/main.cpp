#include <iostream>

using namespace std;

int main() {
    const int MAX = 100;
    int M2[MAX];
    int M2Length = 1;

    for (int i = 0; i <= MAX; ++i) {
        int sum = 0, number;
        cout << "Введите действительное число: ";
        cin >> number;
        if (number == 0)
            break;

        for (int j = 0; j < M2Length-1; j++) {
            sum += M2[j];
        }

        cout << "Середнє арифметичне елементів M1 = " << double (sum / M2Length) << endl;
        for (int k = 0; k < M2Length-1; k++) {
            cout << M2[k] << " ";
        }
        cout << endl;
        if (number > sum / M2Length) {
            M2[i] = number;
            M2Length++;
        } else
            i--;
    }
    for (int i = 0; i < M2Length-1; i++) {
        cout << M2[i] << " ";
    }
    return 0;
}
