// Numerical data types
int is a whole integer value like 4, 100, or 2349. 
It is useful for counting units of things. 

float, double & decimal are useful when we need to use a decimal value.
They are good for things that require more precision than a whole number
like measuring the precise location of an object. 
double is usually the best choice of the three because it is more precise than a float
but faster to process than a decimal. 
However, make sure to use a decimal for financial applications since it is the most precise.

decimal is written specifically as this:
decimal variableName = 489872.76m
dont forget the 'm' character after the number. 

example: 

using Systems;

namespace Numbers
{

	class Program
	{
		static void Main(string[] args)
		{
		  // Number of pizza shops
      	  int pizzaShops = 4332;

	      // Number of employees
	      int totalEmployees = 86928;

	      // Revenue
	      decimal revenue = 390819.28m;

	      // Log the values to the console:
	      Console.WriteLine(pizzaShops);
	      Console.WriteLine(totalEmployees);
	      Console.WriteLine(revenue);
		}
	}
}


// Arithmetic operators
what can we do with numerical data?
we can write expressions using arithmetic. 

addition +
subtraction -
multiplication *
division /

when using operators, it is important to pay attention to data types. 
if we use two integers, it will return an integer every time. 
But, if we combine an integer with a double, the answer will be a double. 

for example:

Console.WriteLine(5 / 3); // prints 1
Console.WriteLine(5 / 3.0); // prints 1.66667

using System;

namespace PlanetCalculations
{
  class Program
  {
    static void Main(string[] args)
    {  
      // Your Age
      int userAge = 30;

      // Length of years on Jupiter (in Earth years)
      double jupiterYears = 11.86;

      // Age on Jupiter
      double jupiterAge = userAge / jupiterYears;
      
      // Time to Jupiter
      double journeyToJupiter = 6.142466;

      // New Age on Earth
      double newEarthAge = userAge + journeyToJupiter;

      // New Age on Jupiter
      double newJupiterAge = newEarthAge / jupiterYears;

      // Log calculations to console
      Console.WriteLine(jupiterAge);
      Console.WriteLine(newEarthAge);
      Console.WriteLine(newJupiterAge);
    }
  }
}


// operator shortcuts
Programmers are always looking for shortcuts. For example, we can condense 
an arithmetic expression using the shorthand '++'.
The combined addition signs represent the idea of incrementing by one. 
We can do the same with subtration '--'

for example:
int apple = 0;
apple++;
Console.Write(apple); // prints 1

if we want to increment by another value, say 3, we would do the following. 
int apple = 0;
apple += 3;
Console.Write(apple); // prints 3

using System;

namespace MakingProgress
{
  class Program
  {
    static void Main(string[] args)
    {
      // declare steps variable
      int steps = 0;

      // Two steps forward 
      steps += 2;

      // One step back 
      steps -= 1;

      // Print result to the console
      Console.WriteLine(steps);
    }
  }
}


// Modulo
one arithmetic operator we have not covered yet is modulo. A modulo returns a remainder, what is 
left over when we divide a number by another number. 

example:
4 % 3 = 1
4 % 2 = 0

modulos are useful because they let us know if a number fits into a larger number or if there will be 
a remainder. 
For example, how many eggs will be left over if I try and fit 56 eggs into creates of a dozen eggs?

int aggs = 56;
int crateAmount = 12;

int eggsLeftOver = eggs 5 crateAmount;
Console.Write(eggsLeftOver); // prints 8

it can also be used to check in a number is odd or even. If a number is even, taking its modulo with
2 it will return a 0 and it it is odd will return a 1. 

int myNum = 85939824;
Console.Write(myNum % 2); // prints 0, so number is even

using System;

namespace ClassTeams
{
  class Program
  {
    static void Main(string[] args)
    {
      // Number of students
      int students = 18;

      // Number of students in a group
      int groupSize = 3;

      // Does groupSize go evenly into students?
      Console.WriteLine(students % groupSize);

    }
  }
}


// built-in methods
so how do we do more advanced mathematical operations? 
for example, how would we perform a square root on a number if the Program
doesnt recognize a square root symbol?

There are several built-in methods that we can use to manipulate numerical data
and perform complex mathematical calculations.

Math.Abs() - will find the absolute value of a number. Example: Math.abs(-5); // returns 5
Math.Sqrt() - will find the square root of a number. Math.sqrt(16); // returns 4
Math.FLoor() - will round the given double or decimal down to the nearest whole number. Math.Floor(8.65); // returns 8
Math.Min() - returns the smaller of the two numbers. Example: Math.min(39, 12); // returns 12

using System;

namespace LowestNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Starting variables 
      int numberOne = 12932;
      int numberTwo = -2828472;

      // Use built-in methods and save to variable 
      double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));

      // Use built-in methods and save to variable 
      double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

      // Print the lowest number
      Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt)); /* Prints: NaN 
      to fix, must add Math.Abs to remove the negative sign on numberTwo variable*/

    }
  }
}


// Using Documentation
There are more built-in methods, they just need to be looked up. 
Here are more:

Math.Pow() // to calculate a specified number raised to the power of another specified number
ex: Math.Pow(2, 3) // returns 8 because it calculate 2^3 = 8

Math.Max() // returns the larger of two specified numbers. Opposite of Math.Min()

Math.Ceiling() // Finds the smallest integer greater than or equal to a specified number. 
ex: Math.Ceiling(4.3) // returns 5 because the smallest integer greater than or equal to 4.3 is 5

using System;

namespace DocumentationHunt
{
  class Program
  {
    static void Main(string[] args)
    {

      double numberOne = 6.5;
      double numberTwo = 4;

      // Raise numberOne to the numberTwo power
      Console.WriteLine(Math.Pow(numberOne, numberTwo));

      // Round numberOne up
      Console.WriteLine(Math.Ceiling(numberOne));

      // Find the larger number between numberOne and numberTwo
      Console.WriteLine(Math.Max(numberOne, numberTwo));

    }
  }
}