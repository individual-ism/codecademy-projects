#include <iostream>
#include <vector>

int main() {
    std::vector<std::vector<char>> board = {{"", "", ""}, {"", "", ""}, {"", "", ""}};

    std::cout << "Welcome to Tic Tac Toe\n";
    std::cout << "To select a spot on the board, please provide your response as 'row, column'\n";
    std::cout << board;
    
} 