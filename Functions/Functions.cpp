#include <iostream>
#include <cmath>
#include <iomanip>
#include <fstream>
#include <sstream>
#include <algorithm>

double CalculateFunction(double x) {
    double function;
    if(x > 5 && x < 10) {
        function = sqrt(pow(pow(x,2)+cbrt(exp(4-x)), 1./5)) + log(abs(2 * x - 4.5));
    }
    else if(x > -1 && x <= 5) {
        function = pow(x, 2) + 3;
    }
    else {
        function = pow(x, -10);
    }
    return function;
}


void RecordToFile(double min, double max, double step) {
    std::string way = "test\\";
    std::ofstream file;
    std::string name;
    do
    {
        std::cout << "Enter file name: ";
        std::cin >> name;
        file.open(way + name); 
        if (!file.is_open())
        {
            std::cout << "Error! The file could not be opened" << std::endl;
        }
    } while (!file.is_open());

    std::stringstream s; 

    double x = min, y;
    while (x <= max) {
        y = CalculateFunction(x);
            if (std::isnan(y) || std::isinf(y)) { // перевірка на розриви
                s << x << " empty" << std::endl;
            }
            else {
                std::ostringstream oss; 
                oss << x << " " << std::setprecision(7) << y;
                std::string result = oss.str(); //присвоює значення з буфера oss 
                std::replace(result.begin(), result.end(), '.', ','); //проглядаємо від початку до кінця і замінюємо крапки на коми
                s << result << std::endl;
            }
            x += step;
    }

    file << s.str(); // виводимо у файл вміст буфера s
    file.close();
    std::cout << "All data has been successfully entered into the file" << std::endl;
}


int main() {
    double min, max, step;
    std::cout << "Input min, max, step: ";
    std::cin >> min >> max >> step;

    while (min == 0 && max == 0) {
        std::cout << "Error: range can't be equal zero" << std::endl;
        std::cout << "Input min, max: ";
        std::cin >> min >> max;
    }
    if (min > max) {
        std::swap(min, max);
    }  
    while ((max - min) < step || step == 0) {
       std::cout << "Step can't be bigger than range or equals zero. Input new step: ";
       std::cin >> step;
    }
   
    RecordToFile(min, max, step);

    system("pause");
    return 0;
}

