using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");

     Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate? ");
     Console.Write("Type YES or NO: ");
     // if a user doesn't type YES but rather yes, modify the variable so its value is uppercase
     string noiseChoise = Console.ReadLine().ToUpper();

     if (noiseChoise == "NO")
     {
      Console.WriteLine("Not much of an adventure if we don't leave our room! THE END.");
     }
     else if (noiseChoise == "YES")
     {
      Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
     }
     Console.Write("Type OPEN or KNOCK: ");
     string doorChoise = Console.ReadLine().ToUpper();

     if (doorChoise == "KNOCK") 
     {
      Console.WriteLine("A voice behind the door speaks. It says, 'Answer this riddle: ' 'Poor people have it. Rich people need it. If you eat it you die. What is it?'");
      Console.Write("Type your answer: ");
      string riddleAnswer = Console.ReadLine().ToUpper();
        if (riddleAnswer == "NOTHING")
        {
          Console.WriteLine("The door opens and NOTHING is there. You turn off the light and run back to your room and lock the door. THE END.");
        }
        else 
        {
          Console.WriteLine("You answered incorrectly. The door doesn't open. THE END.");
        }
     }
     else if (doorChoise == "OPEN")
     {
        Console.WriteLine("The door is locked! See if one of your three keys will open it.");
        Console.Write("Enter a number (1-3): ");
        string keyChoice = Console.ReadLine().ToUpper();

        switch (keyChoice)
        {
          case "1":
            Console.WriteLine("You choose the first key. Lucky Choice! The door opens and NOTHING is there. Strange... THE END.");
            break;
          case "2":
            Console.WriteLine("You choose the second key. The door doesn't open. THE END.");
            break;
          case "3":
            Console.WriteLine("You choose the third key. The door doesn't open. THE END.");
            break;
          default:
            Console.WriteLine("You chose not to try any keys. THE END. ");
            break;
        }
     }

    }
  }
}