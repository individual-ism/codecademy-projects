#include <iostream>

int main() {
    int fork1 {0};
    int fork2 {0};
    int fork3 {0};

    // std::cout << "The year is 2022.\nThe month February.\nThe day, the twenty-third.\n\nPresident of the United States Joseph Robinette Biden, Jr., issued warning to his Ukrainian counterpart, Volodymyr Zelensky, of an impending assault by the forces of the Russian Federation within the next forty-eight hours.\n";
    // std::cout << "In an effort to prepare ";

    std::string first_name;
    std::string last_name;
    std::string us_state;

    std::cout << "Please enter your first name: ";
    std::cin >> first_name;
    std::cout << "Please enter your last name: ";
    std::cin >> last_name;
    std::cout << "\n\nPlease enter your state: ";
    std::cin >> us_state;

    std::cout << "It is 2028.\nFebruary 24th.";
    std::cout << "The United States is in an election year.\nThe European Union is disjointed and divided.\nThe Russian war in Ukraine rages into its seventh year.\n";
    std::cout << "With the United States and Europe focused on that battlefield, China sees an opportunity to expand its reach in Asia...\n\n...starting with Taiwan.\n\n";
    std::cout << "You are the distinguished senator from " << us_state << ", a member on the Foreign Relations committee.\n";

    std::cout << "Do you want to run for reelection?\n\n";
    std::cout << "1) Yes.\n";
    std::cout << "2) No.\n";
    std::cout << "3) Push the decision to later in the year.\n";
    std::cin >> fork1;

    if (fork1 == 1) {
        std::cout << "'Senator " << last_name << ", you know the stakes of your reelection campaign. Your opponents will pounce on your every error, and it could destroy the country if they prevail', says your chief of staff, Casey Milhauser.";
        std::cout << "";
    }
    else if (fork1 == 2) {

    }
    else if (fork1 == 3) {

    }
    else {
        std::cout << "Please enter a valid option number.";
        std::cin >> fork1;
    }
}