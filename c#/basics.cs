// Getting input
we can also read input from a user. The command Console.ReadLine() captures text
that a user types into the console. 

using System;

namespace GettingInput
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("How old are you?");
      string input = Console.ReadLine();  // Console.ReadLine captures user input in the console
      Console.WriteLine($"You are {input} years old!"); // Console.WriteLine prints text to the console
    }
  }
}


// Comments
//
/* */
