#include <iostream>
#include "distance.h"

using namespace std;


int main() {
    double near_dist = -1, near_x, near_y;
    double dist, x, y;

    do {
        cout << "Введите X и Y (через пробел): ";
        cin >> x >> y;
        dist = distance(0, 0, x, y);

        cout << endl;
        cout << "Новая точка (" << x << ", " << y << ")" << endl;
        cout << "Дистанция до начала координат = " << dist << endl;

        if (dist < near_dist || near_dist == -1) {
            cout << "Эта точка ближе всех до начала координат." << endl;
            near_dist = dist;
            near_x = x;
            near_y = y;
        } else
            cout << "Ближайшая точка (" << near_x << ", " << near_y << ")" << endl;

        cout << endl;
        cout << "Продолжить ввод точек? (y/n): ";
        char c;
        cin >> c;
        if (c == 'n')
            break;
    } while (true);

    return 0;
}
