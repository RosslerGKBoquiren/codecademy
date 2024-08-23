using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      // Define the alphabet array
      char[] alphabet = new char[] 
      {
        'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
      };

      // Ask the user for input
      Console.Write("Enter your secret message: ");
      string userInput = Console.ReadLine();

      // Convert the user's input into a character array
      char[] secretMessage = userInput.ToCharArray();

      // Create an array to store the encrypted message
      char[] encryptedMessage = new char[secretMessage.Length];

      // Loop through each character in the secret message
      for (int i = 0; i < secretMessage.Length; i++)
      {
        // Get the current character from the secret message
        char character = secretMessage[i];

        // Check if the character is in the alphabet
        if (char.IsLetter(character))
        {
          // Find the position of the character in the alphabet array
          int alphabetCharacterPosition = Array.IndexOf(alphabet, character);

          // Shift the position by 3 to encrypt it
          int adjustedPosition = (alphabetCharacterPosition + 3) % alphabet.Length;

          // Store the encrypted character in the encryptedMessage array
          encryptedMessage[i] = alphabet[adjustedPosition];
        }
        else
        {
          // If it's not a letter, just copy the character as is
          encryptedMessage[i] = character;
        }
      }

      // Join the array into a new string and display the encrypted message
      string newEncryptedMessage = String.Join("", encryptedMessage);
      Console.WriteLine($"Encrypted message: {newEncryptedMessage}");
    }
  }
}
