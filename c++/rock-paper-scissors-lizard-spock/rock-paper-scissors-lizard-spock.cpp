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

// Rock, Paper, Scissors
int main() {
  srand (time(NULL));

  int computer = rand() % 5 + 1;

  int user = 0;

  std::cout << "====================\n";
  std::cout << "rock paper scissors lizard spock!\n";
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

// Rock, Paper, Scissors, Lizard, Spock
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
  std::cout << "4) 🦎\n";
  std::cout << "5) 👨‍🚀\n";

  std::cout << "Shoot! ";
  
  std::cin >> user;

  if (computer == 1) {
    switch (user) {
        case 2 :
            std::cout << "Paper beats rock; you win.";
            break;
        case 3 :
            std::cout << "Rock crushes scissors; you lose.\n";
            break;
        case 4 :
            std::cout << "Rock crushes lizard; you lose.\n";
            break;
        case 5 :
            std::cout << "Spock vaporizes rock; you win.\n";
            break;
        default :
            std::cout << "You tied with rock.\n";
            break;
    }
  }
  else if (computer == 2) {
    switch (user) {
        case 1 :
            std::cout << "Paper beats rock; you lose.";
            break;
        case 3 :
            std::cout << "Scissors cuts paper; you win.\n";
            break;
        case 4 :
            std::cout << "Lizard eats paper; you win.\n";
            break;
        case 5 :
            std::cout << "Paper disproves Spock; you lose.\n";
            break;
        default :
            std::cout << "You tied with paper.\n";
            break;
    }
  }
  else if (computer == 3) {
    switch (user) {
        case 1 :
            std::cout << "Scissors is beaten by rock; you win.";
            break;
        case 2 :
            std::cout << "Scissors cuts paper; you lose.\n";
            break;
        case 4 :
            std::cout << "Lizard is decapitated by scissors; you lose.\n";
            break;
        case 5 :
            std::cout << "Scissors smashed by Spock; you win.\n";
            break;
        default :
            std::cout << "You tied with scissors.\n";
            break;
    }
  }
  else if (computer == 4) {
    switch (user) {
        case 1 :
            std::cout << "Lizard crushed by rock; you win.";
            break;
        case 2 :
            std::cout << "Lizard eats paper; you lose.\n";
            break;
        case 3 :
            std::cout << "Lizard is decapitated by scissors; you win.\n";
            break;
        case 5 :
            std::cout << "Lizard poisoned Spock; you lose.\n";
            break;
        default :
            std::cout << "You tied with lizard.\n";
            break;
    }
  }
  else {
    switch (user) {
        case 1 :
            std::cout << "Spock vaporized rock; you lose.";
            break;
        case 2 :
            std::cout << "Spock disproven by paper; you win.\n";
            break;
        case 3 :
            std::cout << "Spock smashed scissors; you lose.\n";
            break;
        case 4 :
            std::cout << "Lizard poisoned Spock; you win.\n";
            break;
        default :
            std::cout << "You tied with Spock.\n";
            break;
    }
  }
}