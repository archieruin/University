long double fact(int N)
{
    if(N < 0)
        return 0;
    if (N == 0)
        return 1;
    else
        return N * fact(N - 1);
}


long double custom_pow(int x, int y) {
    int result = 1;
    for (int i = 0; i < y; ++i)
    {
        result *= x;
    }
    return result;
}


