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

using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare the variables
      string beginning = "Once upon a time,";
      string middle = "The kid climbed a tree";
      string end = "Everyone lived happily ever after.";

      // Interpolate the string and the variables
      string story = $"{beginning} I told a story. {middle}, fell and survived. {end}";

      // Print the story to the console 
      Console.WriteLine(story);
    }
  }
}


// Get info about strings
in addition to containing the value of a piece of text, string also contain information
about themselves. It can be usefult o know these properties when working with strings. There are 
several built-in .NET methods that we can use to get more information about strings. It


1. Length
We can find out how many characters exist in a string with .Length method. 
ex: string userTweet = Console.ReadLine();
userTweet.Length; // returns the length of the tweet


2. IndexOf
we can also find the position of a specific character or substring using .IndexOf
This method is useful for searching to see if something exists in a string. 
If it does exist within a string, the method will return the position of the search term in the larger string. 
ex: string word = "radio";
word.IndexOf("a"); // returns 1

using System;

namespace PasswordCheck
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create password
      string password = "a92301j2add";

      // Get password length
      int passwordLength = password.Length;

      // Check if password uses symbol
      int passwordCheck = password.IndexOf("!");

      // Print results
      Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");

    }
  }
}



// Get parts of strings
we can also use built-in .NET methods to grab parts of strings or specific characters in a string. 

1. Substring
grabs part of a string using the specified character position, continues until the end of the string, and returns a new string.
It is useful when we only want to use part of string but keep the original data intact. 
ex:
string plantName = "Cactaceae, Cactus";
int charPosition = plantName.IndexOf("Cactus"); // returns 11
string commonName = plantName.Substring(charPosition); returns Cactus

we can also pass .Substring() second argument which will determine the number of characters in the resulting
substring. 
ex:
string name = "Codecademy";
int start = 2;
int length = 6;
string substringName = name.Substring(start, length); // returns 'decade'


2. Bracket Notation 
its a style of syntax that uses brackets[] and an integer value to identify a particular value in a collection. 
We use it to find a specific character in a s tring. 
ex:
string plantName = "Cactaceae, Cactus";
int charPosition = plantName.IndexOf("u"); // returns 15
char u = plantName[charPosition]; // returns u

using System;

namespace DNA
{
  class Program
  {
    static void Main(string[] args)
    {
      // dna strand
      string startStrand = "ATGCGATGAGCTTAC";

      // find location of "tga"
      int tga = startStrand.IndexOf("TGA");

      // start point and stop point variables
      int startPoint = 0;
      int length = tga + 3;

      // define final strand
      string dna = startStrand.Substring(startPoint, length);
      Console.WriteLine(dna);

      // DNA mutation search
      Console.WriteLine(dna[3]);
    }
  }
}


// Manipulate Strings
There are also built-in .NET methods that we can use to manipulate text data. Using these methods on a string 
doesnt change the string itself, but creates an entriely new one. 

1. ToUpper, ToLower
used to change the case of our strings 
ex:
string shouting = "I'm not shouting, you're shouting".ToUpper();
Console.WriteLine(shouting);
// prints: I'M NOT SHOUTING, YOU'RE SHOUTING

using System;

namespace MovieScript
{
  class Program
  {
    static void Main(string[] args)
    {
      // Script line
      string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";

      // Get camera directions
      int charPosition = script.IndexOf("Close");
      int length = "Close on".Length;
      string cameraDirections = script.Substring(charPosition, length);

      // Get scene description
      charPosition = script.IndexOf("a portrait");
      string sceneDescription = script.Substring(charPosition);

      // Make camera directions uppercase
      cameraDirections = cameraDirections.ToUpper();

      // Make scene description lowercase
      sceneDescription = sceneDescription.ToLower();

      // Print results
      Console.WriteLine($"{cameraDirections} {sceneDescription}");
    }
  }
}