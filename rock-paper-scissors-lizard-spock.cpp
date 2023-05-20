/*
This program will have a user-decided option between rock, paper, scissors, lizard, and Spock, placed in comparison with a random computer-determined choice. It shall exercise the logic described below:

    Scissors cuts Paper.
    Paper covers Rock.
    Rock crushes Lizard.
    Lizard poisons Spock.
    Spock smashes Scissors.
    Scissors decapitate Lizard.
    Lizard eats Paper.
    Paper disproves Spock.
    Spock vaporizes Rock.
    Rock crushes Scissors.
*/

#include <iostream>
#include <stdlib.h>

int main() {
  srand (time(NULL));

  int computer = rand() % 3 + 1;

  int user = 0;

  std::cout << "====================\n";
  std::cout << "rock paper scissors!\n";
  std::cout << "====================\n";

  std::cout << "1) ✊\n";
  std::cout << "2) ✋\n";
  std::cout << "3) ✌️\n";

  std::cout << "Shoot! ";
  
  std::cin >> user;

  if (computer == 1 && user == 2) {
    std::cout << "Paper beats rock; you win.";
  }
  else if (computer == 1 && user == 3) {
    std::cout << "Rock crushes scissors; you lose.\n";
  }
  else if (computer == 2 && user == 1) {
    std::cout << "Rock is consumed by paper; you lose.\n";
  }
  else if (computer == 2 && user == 3) {
    std::cout << "Scissors slice through paper; you win.\n";
  }
  else if (computer == 3 && user == 1) {
    std::cout << "Scissors were demolished by rock; you win.\n";
  }
  else if (computer == 3 && user == 2) {
    std::cout << "Paper slaughtered by scissors; you lose.\n";
  }
  else {
    std::cout << "You tied with the computer; it is an AI invasion.\n";
  }
}