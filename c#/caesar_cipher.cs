using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      
      Console.Write("Secret message: ");
      string userInput = Console.ReadLine().ToLower();
      char[] secretMessage = userInput.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];

      int shift = 3;
    
      for (int i = 0; i < secretMessage.Length; i++)
      {
        char currentChar = secretMessage[i];
        if (char.IsLetter(currentChar))
        {
          int originalPosition = Array.IndexOf(alphabet, currentChar);
          int newPosition = (originalPosition + shift) %alphabet.Length;
          encryptedMessage[i] = alphabet[newPosition];
        }
        else
        {
          encryptedMessage[i] = currentChar;
        }
      }

      string encryptedMessageString = String.Join("", encryptedMessage);
      Console.WriteLine($"Encrypted message: {encryptedMessageString}");
    }
  }
}