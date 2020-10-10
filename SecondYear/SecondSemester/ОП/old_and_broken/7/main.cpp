#include <iostream>

using namespace std;

int main() {
    int doubles = 0;
    int notDoubles = 0;
    int n;
    cout << "Введите N: ";
    cin >> n;

    for (int i = 1; i <= n; i++) {
        if (i % 2) {
            notDoubles++;
        } else {
            doubles++;
        }
    }

    cout << "В последовательности чисел от 1 до " << n << endl;
    cout << "Количество парных чисел: " << doubles << endl;
    cout << "Количество не парных чисел: " << notDoubles;

    return 0;
}
