#include <stdio.h>
int main()
{
    int num1, num2, num3;
    printf(" Enter the first number: ");
    scanf("%d", &num1);
    printf("\n Enter the second number: ");
    scanf("%d", &num2);
    printf("\n Enter the third number: ");
    scanf("%d", &num3);
    if (num1 > num2)
    {
        if (num1 > num3)
        {
            printf("\n The biggest number is: %d \n",num1);
        }
        else
        {
            printf("\n The biggest number is: = %d \n",num3);
        }
    }
    else if (num2 > num3)
    {
        printf("\n The biggest number is: %d \n",num2);
    }
    else
    {
        printf("\n The biggest number is: %d \n",num3);
    }
    return 0;
}
