#include <stdio.h>

int main()
{
    double h, w;

    printf("체중(kg): ");
    scanf_s("%lf", &w);
    printf("키(cm): ");
    scanf_s("%lf", &h);

    double bmi = w / ((h / 100) * (h / 100));
    printf("bmi = %lf\n", bmi);

}
