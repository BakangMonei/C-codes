#include<stdio.h>
#include<conio.h>

void main ()
{
	float m1,m2,m3;
	float per,avg;
	float total;

	printf("Mark 1: ");
	scanf("%f", &m1);
	printf("Mark 2: ");
	scanf("%f", &m2);
	printf("Mark 3: ");
	scanf("%f", &m3);
	total= m1+m2+m3;
	printf("\n Total marks is: %.2f ",total);
	per = (total/300)*100;
	avg = (total/3);
	printf("\n The percentage mark of the student is : %.2f ", per);
	printf("\n The average mark of the Student is: %.2f", avg);

	///// Grade calculation //
	if(per>95) printf("\n Grade: Distinction");
	else if(per>=80) printf("\n Grade : A");
	else if(per>=60) printf("\n Grade : B");
	else if(per>=40) printf("\n Grade : C");
	else if(per<35) printf("\n Fail ");

	getch();
}
