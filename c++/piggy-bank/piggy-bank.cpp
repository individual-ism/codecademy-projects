#include <iostream>

int main() {
  double pesos, reais, soles, dollars;

  std::cout << "Enter number of Colombian Pesos: ";
  std::cin >> pesos;
  std::cout << "Enter number of Brazilian Reais: ";
  std::cin >> reais;
  std::cout << "Enter number of Peruvian Soles: ";
  std::cin >> soles;

  /*
    1 COP = 0.0002205748 USD
    1 BRL = 0.20000037 USD
    1 PEN = 0.27058877 USD
  */
  
  dollars = pesos * 0.0002205748 + reais * 0.20000037 + soles * 0.27058877;

  std::cout << "US Dollars = $" << dollars << "\n";

}
