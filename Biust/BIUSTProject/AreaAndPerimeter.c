//Calculate area and circumference of a circle using functions
#include<stdio.h>
const float PI = 3.1415927;
float area(float radius);
float circum(float radius);
void main() {
 float radius;
 clrscr();
 printf("Radius: ");
 scanf("%f", &radius);
 printf("Area : %.3f\n", area(radius));
 printf("Perimeter: %.3f\n", circum(radius));
 getch();
}
/* return area of a circle */
float area(float radius) {
  return PI * radius * radius;
}
/* return circumference of a circle */
float circum(float radius) {
  return 2 * PI * radius;
}
