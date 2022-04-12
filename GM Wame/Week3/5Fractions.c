#include <stdio.h>

int main()
{
    int a,b,c,d,e,sum;
    float avg;

    printf("Enter first number: ");
    scanf("%d",&a);
    printf("Enter second number: ");
    scanf("%d",&b);
    printf("Enter third number: ");
    scanf("%d",&c);
    printf("Enter fourth number:");
    scanf("%d",&d);
    printf("Enter fifth number: ");
    scanf("%d",&e);

    sum=a+b+c+d+e;
    avg= (float)(a+b+c+d+e)/5;

    printf("\nSum of %d, %d, %d, %d, and %d is = %d", a,b,c,d,e,sum);
    printf("\nAverage of %d, %d, %d, %d, and %d is = %f", a,b,c,d,e,avg);

    return 0;
}
