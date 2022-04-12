#include <stdio.h>
int main(void){
int num;
printf("Enter your mark ");
scanf("%d",&num);
printf(" You entered %d", num); // printing outputs
	if (num>100) printf(" ! Wrong data ");
	else if(num >= 75){
	printf(" You got A grade"); // printing outputs
		}
	else if (num >= 65){ // Note the space between else & if
		printf(" You got B grade");
		}
	else if ( num >=55){
		printf(" You got C grade");
		}
	else if ( num >= 45){
		printf(" You grade D");
		}
   else if ( num >= 35){
		printf(" You grade E");
		}
return 0;
}
