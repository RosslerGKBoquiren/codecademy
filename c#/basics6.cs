// introduction to alternate expressions
good developers won't work too hard. We all push ourselves to get better at coding, but when
something seems difficult or repetitive, there's usually a better way to do it. We

ex: 
bool isEven (int num)
{
	return num % 2 == 0;
}

why bother with curly braces and return keywords for such a short method?
in C# there are other ways to define a method which can save us effort in typing and make our 
code easier to read. 

// expression-bodied definitions
expression-bodied definitions are the first shortcut for writing methods. They're great for writing
one-line methods like the above method. 

We can rewrite this definition as an expression-bodied definition by:
removing the curly braces and return keyword
then adding the fat arrow or => which is composed of the equal sign and greater than symbols. 

ex:

bool isEven(int num) => num % 2 == 0;

This also works for methods that return nothing, aka void:

void Shout(string x) => Console.WriteLine(x.ToUpper());

using System;

namespace AlternateExpressions
{
  class Program
  {
    static void Main(string[] args)
    {
      Welcome("Earth");
      double days = 500;
      double rotations = DaysToRotations(days);
      Console.WriteLine($"In {days} days, the Earth has rotated {rotations} time(s).");
    } 
    
    static double DaysToRotations(double days) => days / 365; // transofmr to expression-bodied
    
    
    static void Welcome(string planet) => Console.WriteLine($"Welcome to {planet}!"); // convert method to expression-bodied definition
    
  }
}


// Methods as Arguments 
say we need to check if there are even values in an array.
First you need an array of values and the IsEven() method that returns true if its argument is even:

int[] numbers = {1, 3, 5, 6, 7, 8};

public static bool IsEven(int numb)
{
	return num % 2 == 0;
}

pass both of these arguments to the method Array.Exists() which returns a boolean value:

bool hasEvenNumber = Array.Exists(numbers, IsEven);

you can see that IsEven, is a method, is passed as the second argument to Array.Exists()

using System;

namespace AlternateExpressions
{
  class Program
  {
  	// Method to be used as second argument
   	public static bool IsLong(string word)
    {
      return word.Length > 8;
    }
      
    static void Main(string[] args)
    {
      // Array to be used as first argument
      string[] adjectives = {"rocky", "mountainous", "cosmic", "extraterrestrial"};
     
      // Call Array.Find() and 
      // Pass in the array and method as arguments
      string firstLongAdjective = Array.Find(adjectives, IsLong);
      
      Console.WriteLine($"The first long word is: {firstLongAdjective}."); /* Prints: The first long word is: mountainous */
    }
  }
}


// Lambda Expressions
the next shortcute, lambda expressions, are great for situations when you need to pass a method as an argument. 
In the past exercise, we used IsEven() to check that an even value exists in the array numbers:

int[] numbers = {1, 3, 5, 6, 7, 8};

public static bool IsEven(int num)
{
	return num % 2 == 0;
}

bool hasEvenNumber = Array.Exists(numbers, IsEven);


When using the original definition with curly braces and return, it takes multiple lines to define the IsEven() method
and other devs will need to jump around our code to find the definition. 
With a lambda expression, we can define IsEven() directly in the method call. We don't even need to give it a name:

bool hasEvenNumber = Array.Exists(numbers, (int num) => num % 2 == 0);

This might look similar to an expression-bodied definition. It sort of does, what makes a lambda expression unique is that it 
is an anonymous method: it has no name. 

using System;

namespace AlternateExpressions
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] spaceRocks = {"meteoroid", "meteor", "meteorite"};
      
      bool makesContact = Array.Exists(spaceRocks, (string s) => s == "meteorite");
      
      if (makesContact)
      {
        Console.WriteLine("At least one space rock has reached the Earth's surface!");
      } 
    } 
    
    static bool HitGround(string s)
    {
      return s == "meteorite";
    }
  }
}


// shorter lambda expressions
Time to put on our detective caps: using deductive reasoning, we can make our lambda expression even shorter.
ex:

bool hasEvenNumbers = Array.Exists(numbers, (int num) => num % 2 == 0);

the type of num is int. It's great to be explicit like this to avoid errors, but some developers wouldnt include int.  

1. remove int without causing any errors:
bool hasEvenNumber = Array.Exists(numbers, (num) => num % 2 == 0);

2. when there is just one parameter in a lambda expression, we dont need the parentheses around the parameter either. 
bool hasEvenNumber = Array.Exists(numbers, num => num % 2 == 0);

using System;

namespace AlternateExpressions
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] spaceRocks = {"meteoroid", "meteor", "meteorite"};
      
      bool makesContact = Array.Exists(spaceRocks, s => s == "meteorite"); // remove the datatype in the parameter for the second argument then remove the parantheses
      
      if (makesContact)
      {
        Console.WriteLine("At least one space rock has reached the Earth's surface!");
      } 
    } 
  }
}


// building arrays
in C# arrays are a collection of values that all share the same data type. You could have an array
of type string that contains a list of your favorite songs or an array of type int that stores a collection of user id. 

ex:

int[] x;
string[] 5;
double[] d;

to declare a variable that holds an array, we first write the type of data that will be stored in an array  
then add the square bracketsp[] to signify that it is holding an array follow by the name of the array  

like a variable, we can define and initialize an array at the same time by specifying the values we want to store in it. 
int[] plantHeights = {3, 4, 6}; 

to declare and initialize an array at the same time, after the array declaration, we use the equal sign to denote
we are storing a value to the array then write out the numbers we are putting in separated by commas. 

You may also see arrays defined and intialized using the 'new' keyword
int[] plantHeights = new int[] {3, 4, 6};

the keyword 'new' signifies that we are instantiating a new array from the array class. 

if you decide to define an array and then initialize it later, you must use the keyword 'new'

ex:
// initialization
int[] plantHeights;

plantHeights = new int[] {3, 4, 6};

using System;

namespace BuildingArrays
{
  class Program
  {
    static void Main(string[] args)
    {
        string[] summerStrut; // declare a string array
        // initialize the array with eight songs
        summerStrut = new string []
        {
          "juice",
          "Missing U",
          "Raspberry Beret", 
          "New York Groove",
          "Make Me Feel",
          "Rebel Rebel", 
          "Despacito",
          "Los Angeles"
        };

        int[] ratings = { 1, 3, 4, 5, 2, 2, 3};
    }
  }
}


// Array Length
often we want to know how many items an array contains. 
We can do this with the .Lenght property.

int[] plantHeights = {3, 4, 6};

// arrayLength will be 3
int arrayLength = plantHeights.Length;

using System;

namespace ArrayLength
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] summerStrut;

      summerStrut = new string[] { "New Song" };
      // write a program that checks to make sure there are the right amount of songs
      int arrayPlaylist = summerStrut.Length;

      if (arrayPlaylist == 8)
      {
        Console.WriteLine("summerStrut Playlist is ready to go!");
      }
      else if (arrayPlaylist > 8)
      {
        Console.WriteLine("Too many songs!");
      }
      else 
      {
        Console.WriteLine("Add some songs!");
      }
    
    }
  }
}


// accessing array items
arrays are useful for storing values, but theyre not very useful if they simply stay there. We also need to access them.
arrays order items in sequence - known as index. 
to access a value from a list, we write out the name of the array followed by brackets[] and within the brackets, the index
number of that value that we want. 

int[] plantHeights = {3, 4, 6};
// plantHeight will be 4
int plantTwoHeight = plantHeights[1];

using System;

namespace AccessingArrays
{
  class Program
  {
    static void Main(string[] args)
    {     
      string[] summerStrut;
      
      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      
      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

      string songName = summerStrut[1]; // assign index of song to variable
      int songRating = ratings[1]; // assign index of rating to variable
      Console.WriteLine($"You rated the song {songName} {songRating} star.");
      
    }
  }
}


// editing arrays
once we create an array, the size of that array is fixed. 
However, it is possible to change the values it contains. 

we can intialize an array that has a length of three without specifying what those values are. Then 
later go back and edit the array to include a new value. 
ex: 
int[] plantHeights = new int[3];
// plantHeights will be equal to [0, 0, 0]

plantHeights[2] = 8;
// plantHeights will now be [0, 0, 8]

When we create the array with a known length but no values, the array stores a default type value 
0 for int, null for string. 


we can also edit the values of pre-existing arrays. 

int[] plantHeights = {3, 4, 6};

plantHeights[1] = 5;
// plantHeights will be [3, 5, 6]

using System;

namespace EditingArrays
{
  class Program
  {
    static void Main(string[] args)
    {     
      string[] summerStrut;
      
      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      
      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
      summerStrut[7] = "I Like It"; // swap the last song
      ratings[7] = 5; // swap the rating
    }
  }
}


// Built-in methods
1. Sort 
Array.Sort() to organize array data into a logical sequence:
int[] plantHeights = {3, 6, 4, 1};
Array.Sort(plantHeights); // {1, 3, 4, 6}


2. Index Of 
takes a value and returns its index. 
Works best when you have a specific value and need tok know where it's located in the array:
int[] plantHeights = {3, 6, 4, 1, 6, 8};
Array.IndexOf(plantHeights, 6); // returns 1

3. Find 
searches a one-dimensional array for a specific value or set of values that match a certain condition
and returns the first occurence in the array 
int[] plantHeights = {3, 6, 4, 1, 6, 8};
int firstHeight = Array.Find(plantHeights, height => height > 5); // find the first occurence of a plant height greater than 5 inches

Find() takes two parameters
-the first is the array 
-the second is a predicate that defines what youre looking for; a method that takes one input and outputs a boolean.
returning a value that match the condition, instead of their index. 


using System;

namespace BuiltInMethods
{
  class Program
  {
    static void Main(string[] args)
    {     
      string[] summerStrut;
      
      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      
      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
      int rating3 = Array.IndexOf(ratings, 3); // to find the index of the first three star song
      Console.WriteLine($"Song number {rating3 + 1} is rated three stars"); /* variable rating3 = 3. But to print it's position, +1 since its 4th in the list but indexed as 3rd. */

      string songWith10Chars = Array.Find(summerStrut, song => song.Length > 10);
      Console.WriteLine($"The first song that has more than 10 characters in the title is {songWith10Chars}"); /* find the first song that has more than 10 characters. In the lambda expression, summerStrut is a parameter, song represents the string list of songs, and song.Length > 10 finds the name of the song in the list with more than 10 characters.  */

      Array.Sort(summerStrut); // sort the list alphabetically
      string firstSong = summerStrut[0]; // assign the first song
      string lastSong = summerStrut[7];// assign the second song
      Console.WriteLine(firstSong); // print the first song
      Console.WriteLine(lastSong);// print the second song
    }
  }
}


// documentation hunt
there are other built-in methods for arrays that can be found in Microsoft documentation.

using System;

namespace DocumentationHunt
{
  class Program
  {
    static void Main(string[] args)
    {     
      string[] summerStrut;
      
      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      
      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
      
      string[] summerStrutCopy = new string[8]; // copy the length of the original playlist
      Array.Copy(summerStrut, summerStrutCopy, 8);
      Console.WriteLine(summerStrutCopy);

      Array.Reverse(summerStrut); // reverse the order of the array
      Console.WriteLine(summerStrut[0]); // print the first song
      Console.WriteLine(summerStrut[7]); // print the last song

      Array.Clear(ratings, 0, ratings.Length); // wipe data and turn them all to 0
      Console.WriteLine(ratings[0]); // print out the first rating

    }
  }
}
