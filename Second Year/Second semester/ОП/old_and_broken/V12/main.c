#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int get_rand(const int min, const int max) {
    return rand() % (max - min + 1) + min;
}

int main() {
    srand((unsigned) time(NULL));

    int size = 10;
    int arr[size];
    int copy_arr[size];
    int counter_to_bigger = 0;
    int counter_to_lower = 0;

    printf("Random array: ");
    for (int i = 0; i < size; ++i) {
        arr[i] = get_rand(1, 10);
        printf("%d ", arr[i]);
    }

    for (int i = 0; i < size; ++i) {
        copy_arr[i] = arr[i];
    }

    int temp;
    for (int i = 0; i < size - 1; i++) {
        for (int j = 0; j < size - i - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
                counter_to_bigger++;
            }
        }
    }

    printf("\nArray sorted by the bubble method (to bigger): ");
    for (int i = 0; i < size; i++) {
        printf("%d ", arr[i]);
    }

    for (int i = 0; i < size - 1; i++) {
        for (int j = 0; j < size - i - 1; j++) {
            if (copy_arr[j] < copy_arr[j + 1]) {
                temp = copy_arr[j];
                copy_arr[j] = copy_arr[j + 1];
                copy_arr[j + 1] = temp;
                counter_to_lower++;
            }
        }
    }

    printf("\nArray sorted by the bubble method (to lower): ");
    for (int i = 0; i < size; i++) {
        printf("%d ", copy_arr[i]);
    }
    printf("\nNumber of actions to bigger = %d", counter_to_bigger);
    printf("\nNumber of actions to lower = %d", counter_to_lower);
    return 0;
}
