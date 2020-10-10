#include <math.h>

float area(float a=10, float b=10, float c=10) {
	float P, S;
	P = (a + b + c) * 0.5;
	S = sqrt((P * (P - a) * (P - b) * (P - c)));
	return S;
}
