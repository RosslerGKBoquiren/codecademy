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


// C# Data Types
int - whole numbers like 1, -56, 948, maximum 2,147,483,647
long - whole numbers but bigger range like -9,223,372,036,854,775,808
float - floating point numbers +- 3.4 x 10^38
double - floating point numbers but more accurate like 239.349, -602.221
decimal - monetary values 
char - single characters like a, &, 
string - string of characters like dog or hello world
bool - boolean values like true or false
DateTime - moments in time 

// Creating Variable with types
When we use data in our program, it is good practice to save them in a variable. 
There are two ways we can assign variables. 

1. int myAge;
myAge = 32;

or 

2. string countryName = "Netherlands";

int evenNumber = 22; 
int oddNumber = 45;
Console.WriteLine(evenNumber + oddNumber); // prints 67
Console.WriteLine(oddNumber - evenNumber); // prints 23

// practice creating variables
using System;
namespace Form
{
  class Program
  {
    static void Main(string[] args)
    {
      // create variables 
      string myName = "Ross Boquiren";
      int myAge = 30;
      double accurateAge = 30.5;
      bool iLikeC# = true;
      // print variables to console
      Console.WriteLine(myName);
      Console.WriteLine(myAge);
      Console.WriteLine(accurateAge);
      Console.log(iLikeC#);
    }
  }
}

// Handling errors
if you forget to specify a data type for your variable, C# will give an error
because it doesn't want you to have random data being used in your application. 
If you use the wrong type definition, like an int when its supposed to be a double, you 
will see an error. 

example: 
using System;

namespace BugSquasher
{
  class Program
  {
    static void Main(string[] args)
    {
      int number = 38498.3222; // wrong data type

      dinosaur = "Barney"; // no data type

      double lock = 293.000; // reserved keyword, lock cannot be used as a variable name

      bool is.yes = true; // improper variable name

      string band = "The Low Anthem" // missing semi colon

    }
  }
}

Converting Data types
because variables have to be strictly types, there may be some circumstances where we want 
to change the type of data a variable is storing. This strategy is known as data type conversion

for example:
double myDouble = 3.2;
int myInt = myDouble; // tries to round myDouble to the nearest whole number. But it wont work

if we did the reversed by converting an Int into a double, its fine. 
C# checks to make sure that when we convert data types from one another, that we are 
not losing any data because that could cause problems in our code. 

There are a couple different ways to do data type conversion:

1. implicit conversion: happens automatically if not data will be lost in the conversion. 
Thats why its possible to convert an Int (which can hold less data) to a double (which
  can hold more) but not the other way around. 

2. explicit conversion: requires a cast operator to convert a data type into another one. 
So if we do want to convert a double into an Int, we could use the operator (int)

so if were to fix the error in our previous code, we write it as follows:

double myDouble = 3.2;
int myint = (int)myDouble; 

using System;

namespace FavoriteNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Ask user for fave number
      Console.Write("Enter your favorite number!: ");

      // Turn that answer into an int
      // int faveNumber = Console.ReadLine();

      // int faveNumber = (int)Console.ReadLine();

      int faveNumber = Convert.ToInt32(Console.ReadLine());
    }
  }
}