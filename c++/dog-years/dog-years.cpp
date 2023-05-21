#include <iostream>

// Initial Solution
int main() {
  // Initializes dog_age variable and sets it to 7
  int dog_age = 5;

  // Initializes early_years variable and sets it equal to 21
  int early_years {21};
  // Initializes later_years variable and sets the formula for determining the age
  int later_years = (dog_age - 2) * 4;
  // Initializes human_years variable and sets it equal to the combined total of early and later years
  int human_years = early_years + later_years;
  
  std::cout << "My name is Riley! Ruff ruff, I am " << human_years << " years old in human years.";
}

// Conditional Solution (Accounts for dogs two and younger)
int main() {
    int dog_age = 7;
    int human_years {0};

    if (dog_age <= 2) {
        human_years = dog_age * 10.5;
    }
    else {
        human_years = (dog_age - 2) * 4 + 21;
    }

    std::cout << "My name is Riley! Ruff ruff, I am " << human_years << " years old in human years.";
}

// Conditional Solution with User Input
int main() {
    std::string dog_name;
    int dog_age {0};
    int human_years {0};

    std::cout << "Enter the name of your dog:\n";
    std::cin >> dog_name;

    std::cout << "Enter the age of your dog in years:\n";
    std::cin >> dog_age;

    if (dog_age <= 2) {
        human_years = dog_age * 10.5;
    }
    else {
        human_years = (dog_age - 2) * 4 + 21;
    }

    std::cout << "My name is " << dog_name << "! Ruff ruff, I am " << human_years << " years old in human years.";
}