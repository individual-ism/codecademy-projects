#include <iostream>
#include <vector>
#include <string>

int main() {
  std::string english_input = "turpentine and turles";
  std::vector<char> vowels {'a', 'e', 'i', 'o', 'u'};
  std::vector<char> result;

  for (int i = 0; i < english_input.size(); i++) {
    for (int j = 0; j < vowels.size(); j++) {
      if (english_input[i] == vowels[j]) {
          result.push_back(english_input[i]);
      }
    }
    if (english_input[i] == 'e' || english_input[i] == 'u') {
      result.push_back(english_input[i]);
    }
  }
  for (int k = 0; k < result.size(); k++) {
    std::cout << result[k];
  }
}