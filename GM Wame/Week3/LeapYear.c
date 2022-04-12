#include <stdio.h>

int main()
{
    int Year;
    printf ("Enter the Year: ", Year);
    scanf ("%d", &Year);

    if (Year%4 == 0 && Year%100 == 0 && Year%400 == 0)
        printf("%d is a LEAP YEAR!!!!", Year);

    else if (Year%4==0 && Year%100!=0)
        printf("%d is a LEAP YEAR!!!!", Year);
    else
        printf ("%d is not a LEAP YEAR!!! Try Another Year", Year);

    return 0;
}
