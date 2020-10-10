#include <iostream>

using namespace std;

int get_rand(const int min, const int max) {
    return rand() % (max - min + 1) + min;
}

int main() {
    int size = 10;
    int *arr = new int[size];
    srand((unsigned) time(NULL));

    cout << "Random array: ";
    for (int i = 0; i < size; ++i) {
        arr[i] = get_rand(1, 10);
        cout << arr[i] << " ";
    }

    int temp;
    for (int i = 0; i < size - 1; i++) {
        for (int j = 0; j < size - i - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }

    cout << endl;
    cout << "Sorted array: ";
    for (int i = 0; i < size; i++) {
        cout << arr[i] << " ";
    }

    int new_size = 0;
    for (int i = 0; i < size; i++) {
        if (arr[i + 1] != arr[i]) {
            new_size++;
        }
    }

    int count = 0;
    int *new_arr = new int[new_size];
    for (int i = 0; i < size; i++) {
        if (arr[i + 1] != arr[i]) {
            new_arr[i - count] = arr[i];
        } else count++;
    }

    delete[] arr;
    arr = new_arr;
    size = new_size;

    cout << endl;
    cout << "Cleaned array: ";
    for (int i = 0; i < size; i++) {
        cout << arr[i] << " ";
    }
    cout << endl;

    return 0;
}
