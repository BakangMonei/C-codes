#include <stdio.h>

int main(){

int length;
int width;

printf("Enter length: ");
scanf("%d",&length);

printf("Enter width: ");
scanf("%d",&width);
    
int area=length*width;
int perimeter=(length+length)+(width+width);

 printf("\nArea of %d and %d is = %d", length,width,area);
 printf("\nPerimeter of %d and %d is = %d", length,width,perimeter);
}