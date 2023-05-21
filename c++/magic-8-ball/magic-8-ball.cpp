#include <iostream>
#include <cstdlib>

// Original solution
int main() {

  std::cout << "MAGIC 8-BALL: ";

  srand(time(NULL));
  int answer = std::rand() % 10;
  std::cout << answer << "\n";

  if (answer == 0) {
    std::cout << "It is certain.\n";
  }
  else if (answer == 1) {
    std::cout << "You may rely on it.\n";
  }
  else if (answer == 2) {
    std::cout << "Outlook good.\n";
  }
  else if (answer == 3) {
    std::cout << "Ask again later.\n";
  }
  else if (answer == 4) {
    std::cout << "Cannot predict now.\n";
  }
  else if (answer == 5) {
    std::cout << "Concentrate and ask again.\n";
  }
  else if (answer == 6) {
    std::cout << "My sources say no.\n";
  }
  else if (answer == 7) {
    std::cout << "Yes.\n";
  }
  else if (answer == 8) {
    std::cout << "It is decidedly so.\n";
  }
  else {
    std::cout << "Very doubtful.\n";
  }
}

// Switch solution
int main() {

  std::cout << "MAGIC 8-BALL: ";

  srand(time(NULL));
  int answer = std::rand() % 10;
  std::cout << answer << "\n";

  switch(answer) {
    case 0 :
        std::cout << "It is certain.\n";
        break;
    case 1 :
        std::cout << "You may rely on it.\n";
        break;
    case 2 :
        std::cout << "Outlook good.\n";
        break;
    case 3 :
        std::cout << "Ask again later.\n";
        break;
    case 4 :
        std::cout << "Cannot predict now.\n";
        break;
    case 5 :
        std::cout << "Concentrate and ask again.\n";
        break;
    case 6 :
        std::cout << "My sources say no.\n";
        break;
    case 7 :
        std::cout << "Yes.\n";
        break;
    case 8 :
        std::cout << "It is decidedly so.\n";
        break;
    default :
        std::cout << "Very doubtful.\n";
        break;
  }
}