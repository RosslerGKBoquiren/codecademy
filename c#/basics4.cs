// Understanding Logic in C#

// Boolean Data types
We can represent Boolean values using the bool data type. 
ex: 
bool variableName = true;

using System;

namespace BooleanDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
          bool answerOne = true;
          bool answerTwo = false;
        }
    }
}


// Comparison Operators
we often need to check if a value is correct or compare two values.
Comparison operators allow us to compare values and evaluate their relationship.  
Expressions that evaluate to boolean values are known as boolean expressions. 

comparison operators include:
1. equals ==
2. inequality !=
3. less than <
4. greater than >
5. less than or equal to <=
6. greater than or equal to >=

ex:
bool answer = 3 < 75;
Console.WriteLine(answer); // prints True

in addition to comparing integers, we can also compare variables, strings, and even boolean values:
bool answer = (true == false);
Console.WriteLine(answer); // prints False

using System;

namespace ComparisonOperators
{
  class Program
  {
    static void Main(string[] args)
    {
      // create a double variable named timToDinner and save the difference in hours
      double timeToDinner = 4;
      double distance = 95;
      double rate = 30;

      // calculate tripDUration
      double tripDuration = distance / rate;
      // comparison check
      bool answer = tripDuration <= timeToDinner;

      Console.WriteLine(answer);
    }
  }
}


// Truth table
we can use operators that use boolean values as input and ouput. 
logical operators include:

1. AND &&. True only if both expressions evaluate to True. 
Otherwise, it will return False.

2. OR ||. Both expressions are evaluated and will return True if at least one of the expressions evaluates to True. 
Otherwise, it will return False. 

3. NOT !. no matter its logical value, evaluates to its opposite. What is true becomes false. And vise versa

ex: 
bool andExample = ((4 > 1) && (2 < 7));
// True and True therefore it evaluates as True. 

bool orExample = ((8 > 6) || (3 > 6));
// true OR False, therefore evalutes to True. 

bool notExample = !(1 < 3);
// NOT true evaluates to False


using System;

namespace LogicalOperators
{
  class Program
  {
    static void Main(string[] args)
    {
      bool beach = true;
      bool hiking = false;
      bool city = true;

      bool yourNeeds = beach && city || hiking;
      bool friendNeeds = beach || hiking;

      bool tripDecision = yourNeeds && friendNeeds;
      Console.WriteLine(tripDecision);
    }
  }
}


// Conditional statements

// if statements
the most basic conditional statement is an if statement. 
string color = "blue";
if (color == "blue")
{
	// this code block will execute only if the value of color is equivalent to "blue"
	Console.WriteLine("color is blue");
}

using System;

namespace IfStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      int socks = 6;
      if (socks <= 3)
      {
        Console.WriteLine("Time to do laundry!");
      }

    }
  }
}


// if... else.. statements
what if the condition is false? An else clause can be added to an if statement to provide
code that will only be executed if the if condition is false. 
ex:
string color = "red";
if (color == "blue")
{
	// this code block will execute only if the value of color is "blue"
	Console.WriteLine("color is blue");
}
else 
{
	// this code block will execute if the value of color is NOT "blue"
	Console.WriteLine("color is NOT blue");
}


using System;

namespace IfElseStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      int people = 10;
      string weather = "bad";
      if (people <= 10 && weather == "nice")
      {
        Console.WriteLine("SaladMart");
      }
      else
      {
        Console.WriteLine("Soup N Sandwich");
      }

    }
  }
}



// Else if statements
What if we want to handle multiple conditions and ahve a different thing happen each time?
Conditional statements can be chained by combining if and else statements into else if. 
ex:
string color = "red";
if (color == "blue")
{
	// this code will execute only if the value of color is "blue"
	Console.WriteLine("color is blue");
}
else if (color == "red")
{
	// this code will execute if the value of color is "red"
	Console.WriteLine("color is NOT blue");
}
else 
{
	// this code will execute if the value of color is not blue or red
	Console.WriteLine("color is NOT blue OR red");
}

using System;

namespace ElseIfStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      int guests = 0;
      if (guests >= 4)
      {
        Console.WriteLine("Catan");
      }
      else if (guests >= 1)
      {
        Console.WriteLine("Innovation");
      }
      else 
      {
        Console.WriteLine("Solitaire");
      }

    }
  }
}



// switch statements
using multiple else if statements can get unwieldy pretty quick. Imagine writing an else if statement 
for every possible number of guests. And you invited 20 people. You have to write a lot of repetitive code which
is hard to read and prone to errors.
If its necessary to evaluate several conditions with their own unique output, a switch statement is the way to go. 

ex:
string color; 
switch (color)
{
	case "blue":
		// execute if the value of color is blue
		Console.WriteLine("color is blue");
		break;
	case "red":
		Console.WriteLine("color is red");
		break;
	case "green":
		Console.WriteLine("color is green");
		break;
	default:
		break;
}

using System;

namespace SwitchStatement
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Pick a genre? ");
        string genre = Console.ReadLine();
        switch (genre)
        {
          case "Drama":
            Console.WriteLine("Citizen Kane");
            break;
          case "Comedy":
            Console.WriteLine("Duck Soup");
            break;
          case "Adventure":
            Console.WriteLine("King Kong");
            break;
          case "Horror":
            Console.WriteLine("Psycho");
            break;
          case "Science Fiction":
            Console.WriteLine("2001: A Space Odyssey");
            break;
          default:
            Console.WriteLine("No movie found");
            break;
        }

    }
  }
}


// Ternary operators
allows for a compact syntax in the case of binary decisions. 
ex:
string color = "blue";
string result = (color == "blue") ? "blue" : "NOT blue";
Console.WriteLine(result);

using System;

namespace TernaryOperator
{
  class Program
  {
    static void Main(string[] args)
    {
      int pepperLength = 4;
      string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";
      Console.WriteLine(message);
    }
  }
}
