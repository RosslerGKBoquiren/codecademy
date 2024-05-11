// Introduction to working with text
In this lesson, we look at two commonly used text data types: char and string

// Building strings
to define a variable as a string, write the data type then the variable name
ex: string variableName = "puppy";

// Escape Character Sequences
What happens when you need to include quotes in a string? You can use an escape sequence.
An escape sequence places a backslash (\) before the inner quotation marks, so the program doesnt
read them accidentally as the end of sequence.  

ex:
string withoutSlash = "Ifemelu said, "Hello!"";
string withSlash = "Ifemelu said, \"Hello!\"";

we can use escape character sequences to create a newline. In the console,
it will print that line below the rest. 
To creat a newline, use the character combination \n.

string newLine = "Ifemelu walked \n to the park.";

using System;

namespace PrideAndPrejudice
{
  class Program
  {
    static void Main(string[] args)
    {
      // First string variable
      string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.";
      // Second string variable
      string firstSpeech = "\"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\"";

      // Print variable and newline
      Console.WriteLine(firstSentence);
      Console.WriteLine("\n");
      Console.WriteLine(firstSpeech);
    }
  }
}


// string concatenation
string concatenation is when we combine strings using the addition symbol (+)
ex:

string yourFaveMusician = "David Bowie";
string myFaveMusician = "Solange";

Console.WriteLine("Your favorite musician is " + yourFaveMusician + " and mine is " + myFaveMusician + ".");

using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare the variables
      string beginning = "Once upon a time,";
      string middle = "I drank wine,";
      string end = "The end.";

      // Concatenate the string and the variables
      string story = beginning + "\n" + middle + "\n" + end;

      // Print the story to the console 
      Console.WriteLine(story);
    }
  }
}


// String Interpolation
While string concatenation is easy to read, it can get annoying to write. Another option 
is string interpolation. 
It enables us to insert our variable values and expressions in the middle of a string without
having to worry about spaces and ponctuation. 

ex:
string yourFaveMusician = "David Bowie";
string myFaveMusician = "Solange";

Console.WriteLine($"Your favorite musician is {yourFaveMusician} and mine is {myFaveMusician}.");