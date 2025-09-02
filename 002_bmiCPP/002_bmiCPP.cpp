#include <iostream>
using namespace std;

int main()
{
    double w, h;
    cout << "체중(kg): ";
    cin >> w;
    cout << "키(cm): ";
    cin >> h;

    double bmi = w / ((h / 100) * (h / 100));
    cout << "BMI = " << bmi << endl;
}
