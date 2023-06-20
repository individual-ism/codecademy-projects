using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      
      Console.Write("Please provide your secret message: ");
      string originalInput = Console.ReadLine();

      char[] secretMessage = originalInput.ToCharArray();
      Console.WriteLine(secretMessage);
      char[] encryptedMessage = new char[secretMessage.Length];

      for (int i = 0; i < secretMessage.Length; i++)
      {
        char charact = secretMessage[i];
        int charIdx = Array.IndexOf(alphabet, Char.ToLower(charact));
        if (charIdx == -1)
        {
          encryptedMessage[i] = charact;
        }
        else
        {
          int newCharIdx = (charIdx + 3) % 26;
          encryptedMessage[i] = alphabet[newCharIdx];
        }
      }
      string encryptedString = String.Join("", encryptedMessage);
      Console.WriteLine(encryptedString);
    }
  }
}