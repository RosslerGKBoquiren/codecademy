// Lists

creating and adding
a list is a sequential data structure that can hold any type. 
Like arrays, you can use them to store any sequential information, like the letters of the alphabet, comments on a blog
the finishing times for a horse race or items on a restaurant meny. 

you create a list using the new keyword like you would create any other class. You specify the type of element
insde angle brackets: <> 

ex:

List<string> citiesList = new List<string>();

you can add elements to the list using the add() method:
citiesList.Add("Delhi");

you can access elements using indices and square brackets:
string city = citiesList[0]

you can also re-assign elements using bracket notation:
citiesList[0] = "New Delhi";

In order to use lists, you need to add this to the top of your file. 
using System.Collections.Generic;

using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<double> marathons = new List<double>();
      marathons.Add(144.07);
      marathons.Add(143.12);

      Console.WriteLine(marathons[1]); // 143.12
    }
  }
}


// object initialization
