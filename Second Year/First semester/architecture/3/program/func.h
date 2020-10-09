#include <iostream>

using namespace std;

int custom_mod(int a, int b){
    while(a - b >= 0) {
        a -= b;
    }
    return a;
}