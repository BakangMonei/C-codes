#include <stdio.h>
int main(){
int principle, rate, time;

printf("Enter principle: ");
scanf("%d",&principle);
printf("Enter rate: ");
scanf("%d",&rate);
printf("Enter time: ");
scanf("%d",&time);

int SimpleInterest=(principle*rate*time)/100;

printf("\nSimple Interest = %d", SimpleInterest);

}
