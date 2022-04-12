#include <stdio.h>
int main() {
  char op;
  double num1, num2;
  printf("Enter an operator (+, -, *, /): ");
  scanf("%c", &op);
printf("Enter num1: ");
  scanf("%lf", &num1);
printf("Enter num2: ");
  scanf("%lf", &num2);

  switch (op) {
    case '+':
      printf("%.1lf + %.1lf = %.1lf", num1, num2, num1 + num2);
      break;
    case '-':
      printf("%.1lf - %.1lf = %.1lf", num1, num2, num1 - num2);
      break;
    case '*':
      printf("%.1lf * %.1lf = %.1lf", num1, num2, num1 * num2);
      break;
    case '/':
      printf("%.1lf / %.1lf = %.1lf", num1, num2, num1 / num2);
      break;
    // operator doesn't match any case constant
    default:
      printf("Wa tsenwa naaare!!! Wrong operators Bariiiiiiiiiiiii!!! irisa (*, +, -, /)");
      printf("Wa bona gore o botlhale!!!!!!!!");
  }

  return 0;
}
