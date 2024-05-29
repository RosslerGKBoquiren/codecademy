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
      string[] questions = new string[] {"The sun is red? ", "Midgets are tall? ", "Gummy Bears are sweet? "};
      bool[] answers = new bool[] {false, false, true};
      bool[] responses = new bool[3];

      if (questions.Length != answers.Length)
      {
        Console.WriteLine("Warning! questions doesn't equal answers");
      }

      int askingIndex = 0;
      foreach (var question in questions)
      {
        string input;
        bool isBool;
        bool inputBool;

        Console.Write(questions);
        Console.Write("True or False? ");
        input = Console.ReadLine();

        isBool = Boolean.TryParse(input, out inputBool);
        if (isBool)
        {
          responses[askingIndex] = inputBool;
        }
        else
        {
          Console.WriteLine("Please respond with 'true' or 'false'.");
          askingIndex--;
        }

        askingIndex++;
      }
    }
  }
}