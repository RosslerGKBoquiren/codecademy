using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = {
        "Is grass green?", 
        "Do clouds float in the sky?", 
        "Is the world flat?", 
        "Does chocolate milk come from brown cows?"
        };

      bool[] answers = {true, true, false, false};
      bool[] responses = new bool[4];

      if (questions.Length != answers.Length)
      {
        Console.WriteLine("There is not enough answers to questions.");
        return;
      }

      
      for (int i = 0; i < questions.Length; i++)
      {
        string input;
        bool isBool;
        bool inputBool;

        Console.WriteLine(questions[i]);
        Console.WriteLine("True or False? ");
        input = Console.ReadLine();
        Console.WriteLine("\n");
        
        isBool = Boolean.TryParse(input, out inputBool);
        if (isBool)
        {
          responses[i] = inputBool;
        }
        else
        {
          Console.WriteLine("Please enter True or False. ");
          i--;
        }
      }

      
      int score = 0;

      for (int i = 0; i < questions.Length; i++)
      {
        if (responses[i] == answers[i])
        {
          score++;
        }
      }
    }
  }
}
