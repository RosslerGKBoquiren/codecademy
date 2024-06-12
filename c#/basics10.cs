// making classes
C# provides built0in data types like string: each instance of the sring type has its own valuea nd functionality

A class represents a custom data type. In C# the class defins the kinds of information and methods included in a custom-type.
You can then make instances of that clasas. 

To begin defining a class, C# uses this structure:

class Forest {

}

The code for a class is usually put into a file of its own, named with the name of the class. In this case it's Forest.cs 
This keeps our code organized and easy to debug. 

In other parts of the code, like Main() in Program.cs, we can use the class.
We make instances, or objects, of the Forest class with the new keyword:

Forest f = new Forest();

We could say f is an instance of the Forest class, or f is of type Forest. 


//Program.cs
using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
    }
  }
}

//Forest.cs
using System;

namespace BasicClasses
{
  class Forest {
    
  }
}



// Fields
we need to associate different pieces of data, like a size and name, to each Forest object. 
in C# these pieces of data are called fields. Fields are one type of class member, which is the general term for the building
blocks of a class. 

Create fields like this:

class Forest {
	public string name;
	public int trees;
}

This migh look similar to defining a variable. It is! Each field is a variable and it will have a different value for each object. 

With the code above, we haven't set the value of either field, so each has a default value. In this case string s defaults to null
int s to 0, and bool s to false. 

It is common practice to name fields using all lowercase (name instead of Name). This makes fields easy to recognize later on. 

Once we create a Forest instance, we can access and edit each field with dot notation:

Forest f = new Forest();
f.name = "Amazon";
Console.WriteLine(f.name); // prints: Amazon

Forest f2 = new Forest();
f2.name = "Congo";
Console.WriteLine(f2.name); // prints: Congo

//Program.cs
using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.name = "Amazon";
      f.biome = "Warm";
      f.trees = 5;
      f.age = 100;
      Console.WriteLine(f.name);
    }
  }
}

Forest.cs
using System;

namespace BasicClasses
{
  class Forest
  {
    public string name;
    public string biome;
    public int trees;
    public int age;

  }

}


// Properties
As of now, a program can plant any value in a Forest field. IF we had an area field of type int, we could set it to 0, 40, or -1249
We need a way to define what values are valid and disallow those that are not. C# provides a tool for that: Properties.  

Properties are another type of class member. Each property is like a spokeperson for a field: it controls the access to that field. 
We can use this to validate values before they are set to a field. A property is made up of two methods:

get() method or getter: called when the property is accessed
set() method or setter: called when the propert is assigned a value. 

This shows a basic Area property without validation:

public int area;
public int Area
{
	get {return area;}
	set {area = value;}
}

The area property is associated with the area field. It's common to name a property with the title-cased version of its
field's name. 

The set() method above uses the keyword value, which represents the value we assign to the property. Back in Program.cs, when we 
access the Area property, the get() and set() methods are called:

Forest f = new Forest();
f.Area = -1; // set() is called
Console.WriteLine(f.Area); // get() is called; prints -1

Here's the same property validation in the Set() method. If we try to set Area to a negative value, it will be changed to 0. 

public int Area {
	get {return area;}
	set 
	{
		if (value < 0) {area = 0;}
		else {area = value;}
	}
}

// in program.cs
Forest f = new Forest();
// set() is called
f.Area = -1;
// get() is called; prints 0
Console.WriteLine(f.Area);


//program.cs
using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.Name = "Congo";
      f.Trees = 0;
      f.age = 0;
      f.biome = "Tropical";
      
      Console.WriteLine(f.Name);
    }
  }
}


//Forest.cs
using System;

namespace BasicClasses
{
  class Forest
  {
    public string name;
    public int trees;
    public int age;
    public string biome;

    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    public int Trees
    {
      get { return trees; }
      set { trees = value; }
    }

    public string Biome
    {
      get { return biome; }
      set 
      {
        if (value == "Tropical" || value == "Temperate" || value == "Boreal") { 
          biome = value; 
        }
        else 
        { 
          biome = "Unknown"; 
        }
      }
    }
  }
}


// automatic properties
it might felt tedious to write the same getter and setter for the Name and Trees properties. 
The basic getter and setter is so comong that there is a short hand called an automatic property.  

ex: 
public string Size
{ get; set; }


// public vs private
at this point we have built fields to associate data with a class and  
properties to control the getting and setting of each field. As it is now, 
any code outside the Forest class can "sneak past" our properties by 
directly accessing the field:

f.age = 32; // using property
f.age = -1; // using field

The second line avoids the property's validation by directly accessing the field. 
we can fix this by using the access modifiers public and private. 

For simplicity, we've been adding public to every member so far. 
That allows code to access the members from the Main() method which doesn't belong to the Forest class.
When we change a field from public to private it will no longer be accessible
from Main(). Although code inside the Forest class can still access it. 

Forest.cs 
using System;

namespace BasicClasses
{
  class Forest
  {
    public int age;
    private string biome;
    
    public string Name
    { get; set; }
    
    public int Trees
    { get; set; }
    
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
  }

}


Program.cs 
using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.Name = "Congo";
      f.Trees = 0;
      f.age = 0;
      f.Biome = "Desert";
      
      Console.WriteLine(f.Name);
      Console.WriteLine(f.Biome);
    }
  }
}
