// call a method
You've been using methods since your started learning C#
Commands like Console.WriteLine() and Math.Min() are methods. 

using System;

namespace CallAMethod
{
  class Program
  {
    static void Main(string[] args)
    {
      string msg = "Yabba dabba doo!";
      Math.Min(5, 8);
      Console.WriteLine(msg);
      Console.WriteLine(msg.Substring(0, 1));
    }
  }
}


// Capture output
like a math function or a factory machine, a method takes input and returns output. 
ex:
int smallerNumber = Math.Min(3, 4);

Math.Min() returns the value 3, so you can imagine that value taking its place. 

int smallerNumber = 3;

we can then use that variable as input to other methods like Console.WriteLine()
ex: 
Console.WriteLine(smallerNumber);

in this case, we can take a shortcut by nesting the method calls:
Console.WriteLine(Math.Min(3, 4));

using System;

namespace CaptureOutput
{
  class Program
  {
    static void Main(string[] args)
    {
      string designer = "Anders Hejlsberg";
      int indexOfSpace = designer.IndexOf(" ");
      string secondName = designer.Substring(indexOfSpace);
      Console.WriteLine(secondName);
    }
  }
}

// define a method
up until now, you've been calling built-in methods that are available whenever 
you use C#. 
Sometimes you need a custom method for your specific program. 

the basic structure of a method looks like this:

static void YourMethodName()
{

}

It is convention to use PascalCase to name your method. The name starts with an uppercase letter
and each word following begins with an uppercase as well. It's not required in C# but it makes your code
easier to read for other developers. 

The body of your method goes between the curly braces: {}

Whenever the method is called, the code in the body is executed. 

static void YourMethodName()
{
	Console.WriteLine("Hi there!");
}

Just like any other method, we call it with parantheses:
YourMethodName()

using System;

namespace DefineAMethod
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets();
    }
    static void VisitPlanets()
    {
      Console.WriteLine("You visited many new planets...");
    }
  }
}


// define parameters
remember calling methods with arguments like math.Min(3, 4)?
Methods that you define can use arguments as well, making them more versatile and useful. 

While we are defining our method, we don't know the actual argument values that will be used when calling the method.
But we do know the expected data type and how it will be used. We can use thsi information to define a paramater which sort of 
works like a variable within a method. The
ex:

static void YourMethodName(string identity)
{
	Console.WriteLine(identity);
}

The YourMethodName() method now has one parameter named identity of type string.
Separate multiple parameters with commas:

static void YourMethodName(string identity, int age)
{
	Console.WriteLine($"{identity} is {age} years old.");
}

When you call your method, the values to be used are called arguments. 
ex:
YourMethodName("Yoda", 900);

using System;

namespace DefineParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets(3);
      VisitPlanets(300);
      VisitPlanets(30000);
    }
    
    static void VisitPlanets(int numberOfPlanets)
    {
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
    }
  }
}

// A note on parameters
One thing to watch for with parameters: they can only be used inside their method.  

static void YourMethodName(string message)
{
	Console.WriteLine(message);
}
Console.WriteLine(message); // causes an error

youll see an error like:
error CS0103: The name 'message' does not exist in the current context

using System;

namespace ANoteOnParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets(3);
      VisitPlanets(4);
      VisitPlanets(5);
      numberOfPlanets(5); // error
    }
    
    static void VisitPlanets(int numberOfPlanets)
    {
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
    }

  }
}


// optional parameters
To make our functions even more flexible, we can make certain parameters optional. 
If someone calls your method without all the parameters, the method will assign a default value to those
missing parameters.

All you have to do is use the equals sign (=) when defining the method. In this example, 
punctuation is an optional parameter and its default value is "."

static void Main(string[] args)
{
	YourMethodName("I'm hungry", "!"); // prints: I'm hungry!
	YourMethodName("I'm hungry"); // prints: I'm hungry. 
}

static void YourMethodName(string message, string punctuation = ".")
{
	Console.WriteLine(message + punctuation);
}

using System;

namespace OptionalParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets(3);
      VisitPlanets(4);
      VisitPlanets(5);
      VisitPlanets();
    }
    
    static void VisitPlanets(int numberOfPlanets = 0)
    {
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
    }
  }
}


// Named arguments
say your method has lots of optional parameters, but you only want to specify one when you call it.  
ex: in this example, you have five optional parameters
static void YourMethodName(int a = 0, int b = 0, int c = 0, int d = 0, int e = 0)
{

}

When you call the method, you only want to specify d. but calling the method this way would set a to 4 not d.
Refer to the parameter by its name instead:

YourMethodName(d: 4);

with named argumnets, you can list them in any order:

YourMethodName(d: 4, b: 1, a: 2);

You can also mix named arguments with positional arguments, but positional arguments MUST come before named arguments
YourMethodName(2, 1, d: 4); // a is 2, b is 1, d is 4
YourMethodName(d: 4, 2, 1); // error

using System;

namespace NamedArguments
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets();
      VisitPlanets(numberOfPlanets: 2);
      VisitPlanets(name: "John", numberOfPlanets: 2);
    }
    
    static void VisitPlanets(
      string adjective = "brave",
      string name = "Cosmonaut", 
      int numberOfPlanets = 0,
      double gForce = 4.2)
    {
      Console.WriteLine($"Welcome back, {adjective} {name}.");
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
      Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
    }
  }
}

// Method Overloading
Say you want to use Math.Round() and find at least 8 versions. They all have the same name: Math.Round()
What's happening here is called method overloading and each version is called an overload. 
The overloads are different because they have either different parameter types of different number of parameters. 

Lets examine:
Math.Round(Double, Int32) and Math.Round(Double)

The first overload, Math.Round(Double, Int32). rounds the double to the ints number of decimal points. 

Math.Round(3.14159, 2); // returns 3.14

The second Math.Round(double) rounds the double to the nearest integer

Math.Round(3.14159); // returns 3

In C# when we say that the methods are different, we are really talking about their method signatures, which is the
method's name and parameter types in order. 

using System;

namespace MethodOverloading
{
  class Program
  {
    static void Main(string[] args)
    {
      NamePets("Laika", "Albert");
      NamePets("Mango", "Puddy", "Bucket");
      NamePets();
    }

    static void NamePets(string name, string name2)
    {
      Console.WriteLine($"Your pets {name} and {name2} will be joining your voyage across space!");
    }

    static void NamePets(string name, string name2, string name3)
    {
      Console.WriteLine($"Your pets {name}, {name2}, and {name3}, will be joining your voyage across space!");
    }

    static void NamePets()
    {
      Console.WriteLine("Aw, you have no spacefaring pets :(");
    }
  }
}


// method output
whats the outcome of calling a method?
Sometimes a message is printed to the console.
Sometimes a value is returned. Math.Floor(15.6); // returns 15
sometimes a variable is altered.
int number;
bool success = Int32.TryParse("10602", out number);
// number is 10602 and success is true

// Return
The basic way to return values from a method is to use a return statement. 
Lets start with an example below. It contains a defintion of the Yell() method, which returns
a string, and it calls that method in Main()

static string Yell(string phrase)
{
	return phrase.ToUpper();
}

public static void Main()
{
	string output = Yell("Who's there?");
	Console.WriteLine(output); // prints WHO'S THERE?
}


The keyword return tells the computer to exit the method and return a value to wherever the method was called. 

When a method is declared, it must announce the type of value it will return. In this case, Yell() returns a string 
so it has the string modifier.

That first line of method is called a method declaration. So we can say that the method declaration must contain the type of return value

using System;

namespace Return
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(DecoratePlanet("Jupiter"));
    }
    static string DecoratePlanet(string planetName)
    {
      return $"*.*.* Welcome to {planetName} *.*.*";
    }
	}
}


// return erros
when we call a method, we would like to know what type of value will be returned. 
So when we call a method we would like to know what type of value will be returned.
This method definition must contain the type of the return value: if a method returns an integer, 
its return type must be int; if it returns text, it must be string, and so on. If the method returns nothing, use void. 

using System;

namespace ReturnErrors
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(DecoratePlanet("Mars")); 
      Console.WriteLine("Is Pluto really a dwarf...?");
      Console.WriteLine(IsPlutoADwarf());
      Console.WriteLine("Then how many planets are there in the galaxy...?");
      Console.WriteLine(CountThePlanets());
    }
    
    static string DecoratePlanet(string planet)
    {
       return $"*..*..* Welcome to {planet} *..*..*";
    }
    
    static bool IsPlutoADwarf()
    {
      bool answer = true;
      return answer;
    }
    
    static string CountThePlanets()
    {
      return "8 planets, usually";
    }
	}
}



// out
a method can only return one value but sometimes you need to output two pieces of information. 
Calling a method that uses an out parameter is one way to return multiple values. 

For example, the Int32.TryParse() method tries to parse its input as an integer. If it can properly parse 
the input, the method returns true and sets its out variable to the new value. If it cannot properly parse the input,
the method returns false and sets the out variable to 0. 

ex:
public static bool TryParse (string s, out int result);

the method returns a boolean and accepts a string and a variable that has been declared of type int as input. 

int number;
bool success = Int32.TryParse("10602", out number); // number is 10602 and success is true
int number2;
bool success2 = Int32.TryParse(" !!! ", out number2); // number2 is 0 and success2 is false

using System;

namespace OutParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      string ageAsString = "102";
      string nameAsString = "Granny";

      int ageAsInt;
      bool outcome;
      
      outcome = Int32.TryParse(ageAsString, out ageAsInt);
      Console.WriteLine(outcome);
      Console.WriteLine(ageAsInt);

      int nameAsInt;
      bool outcome2;

      outcome2 = Int32.TryParse(nameAsString, out nameAsInt);
    }    
  }
}


// Using out
we can use out parameters in our own methods as well. In this example, Yell() 
converts phrase to uppercase and sets a boolean variable to true:

static string Yell(string phrase, out bool wasYellCalled)
{
  wasYellCalled = true;
  return phrase.ToUpper();
}

The out parameter must have the out keyword and its expected type  
The out parameter must be set to a value before the method ends

When calling the method, don't forget to use the out keyword as well. 

string message = "garrrr";
Yell(message, out bool flag); // returns "GARRR" and flag is true

using System;

namespace UsingOut
{
  class Program
  {
    static void Main(string[] args)
    {
      string statement = "GARRR";
      string murmur = Whisper(statement, out bool marker);
      Console.WriteLine(murmur);
    }    
    static string Whisper(string phrase, out bool marker)
    {
      marker = true;
      return phrase.ToLower();
    }
  }
}


// Out errors
as with return, out is a very useful keyword but it can lead to errors if used incorrectly. 
Here are two common ones:

This error means that the out parameter needs to be assigned a value within the method:
error CS0177: The out parameter 'success' must be assigned to before control leaves the current method

This error means you called a method that expects an out parameter but you didnt use the out keyword. 
error CS1620: Argument 2 must be passed with the 'out' keyword

using System;

namespace OutErrors
{
  class Program
  {
    static void Main(string[] args)
    {
      string statement = "GARRRR";
      bool marker;
      string murmur = Whisper(statement, out marker); // error not using out 
      Console.WriteLine(murmur);
    }  
    
    static string Whisper(string phrase, out bool wasWhisperCalled)
    {
      wasWhisperCalled = true; // missing bool
      return phrase.ToLower();
    }
  } 
}


using System;

namespace ReviewMethodOutput
{
  class Program
  {
    static void Main(string[] args)
    {
      // Define variables
      string destination = "Neptune";
      string galaxyString = "8";
      int galaxyInt;
      string welcomeMessage;
      bool outcome;
      
      // Call DecoratePlanet() and TryParse() here
      welcomeMessage = DecoratePlanet(destination); // call DecoratePlanet() with an argument. Then store returned to variable
      outcome = Int32.TryParse(galaxyString, out galaxyInt); // Call Int32.TryParse. 
      
      // Print results
      Console.WriteLine(welcomeMessage);
      Console.WriteLine($"Parsed to int? {outcome}: {galaxyInt}");
      
    }
    
    // Define a method that returns a string
    static string DecoratePlanet(string planet)
    {
       return $"*..*..* Welcome to {planet} *..*..*";
    }
    
    // Define a method with out
    static string Whisper(string phrase, out bool wasWhisperCalled)
    {
      wasWhisperCalled = true;
      return phrase.ToLower();
    }
  }
}