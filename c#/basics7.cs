// Introduction to loops

imagine you're building a video game and in this game, you want to add 15 aliens to the screen. 
Crate a variable and call the method 15 times?
That approach takes a long time and it can easily lead to mistakes. 
instead, lets give the instruction once and tell the computer how many time to repeat them:

for (int i = 0; i < 15; i++)
{
	AddAlien();
}


// while loop
Loops are used to repeat a set of instructions based on a set of conditions. If this makes you think 
of conditional statements, you're not wrong!
The while loops looks very simnilar to an if statement. Just like if statement, it executes the code 
inside of it if the condition is true. 

However, unlike an if s statement that runs once, a while loop will continue to execute the code inside of it 
over and over again while the condition is true. 
The computer is constantly checking to see if the condition is satisfied. For this reason, while loops are useful when you know
at thwat point a program should stop, rather than the number of times it should repeat. 


using System;

namespace WhileLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      int emails = 20;  
      
      while (emails > 0) // while loop to check if there are any emails 
        {
          emails--; // decrement by 1 while emails is more than 0
          Console.WriteLine($"One email deleted, {emails} emails left");
        }

     
      Console.WriteLine("INBOX ZERO ACHIEVED!"); // once emails have reached 0, print a congratulatory message
      
      }
    }
  }
}


// Do while loop
similar to while loop, a do...while will continue runnign until a stopping condition is met.
Instead of checking the condition before the code block executes, the program in the block runs once
and then checks the conditional statement. It will either stop or continue to execute until the condition is
no longer true. 

using System;

namespace DoWhileLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      bool buttonClick = true;
      do
      {
        Console.WriteLine("BLARRRRRRRRR");
      } while (!buttonClick);

      Console.WriteLine("Time for a five muinute break.");
      
    }
  }
}



// for loop

what if we want our code to execute a specific number of times? We can use a for loop to do that. 

for (initialization; stopping condition; iteration statement)
{
  statement;
}

the for loop tells the computer how many times to repeat te instructions using the for keyword and three expressions
inside of parentheses. Each of these expressions use what known as an iterator variable. Which keeps track of how many times the program
goes through the loop. 

These expressions are:

1. initialization: where the loop begins
2. Stopping condition: the condition that the iterator variable is evaluated against
3. iterations tatement: used to update the iterator variable on each loop 

The for loop is good to use when you know the number of times you'd like to perform a task before you begin.
Like printing three copies of a document or inserting eight rows into a table. 

using System;

namespace ForLoop
{
  class Program
  {
    static void Main(string[] args)
    { 
      for (int i = 1; i < 17; i++)
      {
        CreateTemplate(i);
      }

    }
    
    static void CreateTemplate(int week)
    {
      Console.WriteLine($"Week {week}");
      Console.WriteLine("Announcements: \n \n \n ");
      Console.WriteLine("Report Backs: \n \n \n");
      Console.WriteLine("Discussion Items: \n \n \n");
    }
    
    
  }
}



// for each loop
Theres one more way to give looping instructions to a computer. We define a sequence of values and tell the computer
to repeat the instructions for each item in the sequence. 

foreach(type element in sequence)
{
  statement;
}

The foreach loop is used to iterate over collections, such as an array. 
In our video game, we want to play a melody. We can do that by iterating through a list of individual notes, playing 
one after the other.

string[] meloday = {"a", "b", "c", "c", "b"};

and the loop would look like:
foreach(string note in melody)
{
  PlayMusic(note);
}

Use this loop when you need to perform a task for every item in a list or when the order of things must be maintained. 

using System;

namespace ForEachLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };
      
      foreach (string item in todo)
      {
        CreateTodoItem(item);
      }

    }
    
    static void CreateTodoItem(string item)
    {
      Console.WriteLine($"[] {item}");
    }
  }
}



// comparing loops
There are lots of similarities between different types of loops. 
We just showed how we can use a foreach loop to iterate through an array. But we can also use a for loop 
to iterate through an array:

string[] items = {"potion", "dagger", "shield", "plant"};

for (int i = 0; i < items.Length; i++)
{
  Console.WriteLine(items[i]);
}

we could even write a complicated whiel loop that starts a counter at 0. 
int i = 0;
while (i < items.Length)
{ 
  Console.WriteLine(items[i]); 
  i++; 
}

Since a foreach loop does the same thing as the other two but is more concise, it is less prone to errors and the better 
choise in this circumstance. 
string[] items = { "potion", "dagger", "shield", "plant" };

foreach (string item in items)
{
  Console.WriteLine(item);
}


1. while loops are good when you know your stopping condition. 
2. do while loops are only necessary if you want something to run once but then stop if a condition is met. 
3. for loops are best if you want something to run a specific number of times 
4. foreach loops are best to loop over an array or any other collection. 

using System;

namespace ComparingLoops
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] websites = { "twitter", "facebook", "gmail" };
      
      foreach(string website in websites)
      {
        Console.WriteLine(website);
      }
    }
  }
}



// jump statements
There are a few keywords we can use to add further control flow to our loops. 

// break
at any point within a loop block, you can end it by using the break keyword 

// continue
the continue keyword is used to bypass portions of code. It will ignore whatever comes after it in the loop and then will go 
back to the top and start the loop again. 

int bats = 10;

for(int i = 0; i <= 10; i++)
{
  if (i < 9)
  {
    continue;
  }

  // this will be skipped until i is no longer less than 9
  Console.WriteLine(i);
}

so while the loop starts at 0, nothing will print to the console until i is equal to 9. 


// return
the return keyword is another way to exit a loop within a method. 
When a return is used, it breaks out of the loop and returns control to the point in the program where the method was called.

class MainClass {
  public static void Main (string[] args) {
    UnlockDoor();
    // after it hits the return statement, it will more on to this method
    PickUpSword();
  }
  static bool UnlockDoor()
  {
    bool doorIsLocked = true;

    // this code will keep running
    while (doorIsLocked)
    {
      bool keyWound = TryKey();

      // eventually if this stopping condition is true,
      // it will break out of the while loop
      if (keyFound)
      {
        //this return statement will break out of the entire method
        return true;
      }
    }
    return false;
  }
}

You should only use return if you need to exit a method because it will break out of all loops.

using System;

namespace JumpStatements
{
  class Program
  {
    static void Main(string[] args)
    {
      bool buttonClick = true;
      int alarm = 0;
      do
      {
        if (alarm == 3)
        {
          buttonClick = false;
          break;
        }
        alarm++;
        Console.WriteLine("BLARRRRR");
      } while(!buttonClick);
    }
  }
}
