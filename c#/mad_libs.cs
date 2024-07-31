using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /* Madlibs 
      Set up*/
      /*
      This program ...
      Author: ...
      */


      // Let the user know that the program is starting:
      Console.WriteLine("The program is starting!\n");

      // Give the Mad Lib a title:
      string title = "Madlibs\n";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.Write("Please enter your name: \n");
      string name = Console.ReadLine();
      Console.WriteLine("Name saved!\n");

      Console.Write("Enter an Adjective #1: \n");
      string adjective1 = Console.ReadLine();
      Console.WriteLine("Adjective #1 saved!\n");

      Console.Write("Please enter adjective #2: \n");
      string adjective2 = Console.ReadLine();
      Console.WriteLine("Adjective #2 saved!\n");

      Console.WriteLine("Please enter adjective #3: \n");
      string adjective3 = Console.ReadLine();
      Console.WriteLine("Adjective #3 saved!\n");

      Console.Write("Press any key to continue...");
      Console.ReadKey();

      Console.Clear();

      Console.WriteLine("Please enter a verb: \n");
      string verb = Console.ReadLine();
      Console.WriteLine("Verb saved!\n");

      Console.Write("Press any key to continue...");
      Console.ReadKey();

      Console.Clear();

      Console.Write("Please enter a noun: \n");
      string noun1 = Console.ReadLine();
      Console.WriteLine("Noun #1 saved!\n");

      Console.Write("Please enter noun #2: \n");
      string noun2 = Console.ReadLine();
      Console.WriteLine("Noun #2 saved!\n");

      Console.Write("Press any key to continue...");
      Console.ReadKey();

      Console.Clear();

      Console.Write("Enter a value for the following: \nAn animal: \n");
      string animal = Console.ReadLine();
      Console.WriteLine("Animal saved!\n");

      Console.Write("Enter a value for food: \n");
      string food = Console.ReadLine();
      Console.WriteLine("Food saved!\n");

      Console.Write("Please enter a value for fruit: \n");
      string fruit = Console.ReadLine();
      Console.WriteLine("Fruit saved!\n");

      Console.Write("Please enter a value for a superhero: \n");
      string superhero = Console.ReadLine();
      Console.WriteLine("Superhero saved!\n");

      Console.Write("Please enter a value for a country: \n");
      string country = Console.ReadLine();
      Console.WriteLine("Coutnry saved!\n");

      Console.Write("Please enter a value for a dessert: \n");
      string dessert = Console.ReadLine();
      Console.WriteLine("Dessert saved!\n");

      Console.Write("Please enter a value for a year: \n");
      int year = Console.ReadLine();
      Console.WriteLine("Year saved!\n");

      Console.Write("Press any key to continue...");
      Console.ReadKey();

      Console.Clear();

      // The template for the story:

      string story = $"This morning {name} woke up feeling{adjective1}. 'It is going to be an {adjective2} day!' Outside, a bunch of {animal}s were protesting to keep 
      {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adjective3}. Concerned, {name} texted {superhero}, who flew 
      {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
    }
  }
}
