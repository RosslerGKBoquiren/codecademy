PHP STRINGS
A string is a sequence of characters which can contain any letters, numbers, symbols, or spaces surrounded by quotation marks.

example:
<?php
echo "My first string"; // prints: My first string

# every part of a program is text, but strings are the parts we intend to keep as data 
# not as instructions to be executed by computer


ESCAPE SEQUENCES
Consider the following string: "She said "hi" to the dog."
The computer will see two strings "She said" and "to the dog."
An escape sequence usually consists of a backslash (\) followed by another character

example:
<?php
echo "She said \"hi\" to the dog"; // Prints: She said "hi" to the dog.

Quotation marks aren't the only symbol requiring an escape sequence. When we print
multiple strings, PHP will print them to the same line by default.

example:
<?php
echo "1. Go to the gym";
echo "2. cook dinner" 
// Prints: 1. Go to the gym 2. cook dinner

To print the second string on a new line, we can use the newline escape sequence(\n)
<?php
echo "1. Go to the gym";
echo "\n2. cook dinner" 
/* Prints:
1. Go to the gym
2. cook dinner
*/

My example:
<?php
echo "1. finish studying PHP";
echo "\n2. go to sleep"; # newline
echo "\n3. \"wake up\" refreshed" # mix of newline and backslash


STRING CONCATENATION
useful to combine two strings together (.)

example:
<?php
echo "one" . "two"; //Prints: onetwo

the computer won't make assumptions for us. It will combine strings as they are without adding any spaces or line-breaks.
If we want spaces, we have to add them ourselves.

example:
<?php
echo "one " . "two"; //prints: one two

we can also combine or chain our operations:

<?php 
echo "one" . " " . "two" . " " . "three"; //Prints: one two three

<?php
// Write your code below:   
echo "Code" . "cademy"; 

echo "\nMy name is:" . " Ross";
echo "\n" . "tur" . "duck" . "en";
//Prints:
Codecademy
My name is: Ross
turducken


VARIABLES
we store values in Variables so that we can easily reuse them throughout a program
$my_name = "Ross Boquiren";

$ = sigil 
my_name = variable name 
"Ross Boquiren" = variable value 

in PHP variables can contain numbers, letters and underscores but they have to start with a letter
or an underscore. Variables names are case sensitive, meaning that PHP will treat the variables 
$my_example and $My_example as two different variables. 

<?php
// Write your code below:
$my_age = "30";
$biography = "\nA working student, hardly working and mainly studying."; 
$favorite_food = "\n" . "tur" . "duck" . "en"; 


USING VARIABLES 
<?php
// Write your code below:
$name = "Ross";
$language = "English";
echo "My name is " . $name;
echo "\n" . "I speak " . $language; // concatenating variables with strings + newline
// Prints:
My name is Ross
I speak English 


VARIABLE PARSING 
There's an easier way to concatenate strings and variables through PARSING.
example:

<?php
$dog_name = "Jason";
$favorite_food = "poopoo";
$color = "black";

echo "I have a $color dog named $dog_name and her favorite food is $favorite_food.";
//prints: I have a black dog named Jason and her favorite food is poopoo. 

If by any change the computer was looking for a variable and couldn't find one due to spelling,
php allows us to indiciate the variable name by warpping it in curly braces to avoid any confusion. 

example: 
<?php
$dog_name = "Jason";
$favorite_food = "poopoo";
$color = "black";

echo "I have a ${color}ish dog named $dog_name and her favorite_food is ${favorite_food}s.";
// Prints: I have a blackish dog named Jason and her favorite food is poopoos. 

<?php
// Fill in the blanks in the code below:
  $noun = "Jason";
  $adjective = "ugly";
  $verb = "poop";

  echo "The world's most beloved ${noun} was very ${adjective} and loved to ${verb} every single day.";
//Fix the code below and uncomment it:
 echo "\nI have always been obsessed with ${noun}s. I'm ${adjective}ish. I'm always ${verb}ing.";
//prints: The world's most beloved Jason was very ugly and loved to poop every single day.
I have always been obsessed with Jasons. I'm uglyish. I'm always pooping. 


VARIABLE REASSIGNMENT
reassigning a variable using the assignment operator on a variable that's already been declared:

$favorite_food = "Red curry with eggplant";
echo $favorite_food; //Prints: Red Curry with eggplant

// Reassign the value of $favorite_food to a new string
$favorite_food = "Pizza";
echo $favorite_food; //Prints: Pizza

<?php
  $movie = "___";
// Add your code here:
$movie = "Superman";
$old_favorite = $movie;

  echo "I'm a fickle person, my favorite movie used to be $movie.";
  
// Add a statement here:
  $movie = "Batman";
  
  echo "\nBut now my favorite is $movie.";
  
// Add a statement below:
echo "I love $old_favorite."; // parsing

//Print: I'm a fickle person, my favorite movie used to be Superman.
But now my favorite is Batman. I love Superman. 


CONCATENATING ASSIGNMENT OPERATOR
(.=)

Instead of doing:
$full_name = "Ross" . " " . "Boquiren";
or
$full_name = "Ross";
$full_name = $full_name . " Boquiren";

Use this instead:
$full_name = "Ross";
$full_name .= " Boquiren"
echo $full_name; //Prints: Ross Boquiren


<?php
  echo "I'm going on a picnic!";

  $sentence = "\nI'm going on a picnic, and I'm taking apples";

  echo $sentence;

// Write your code below:

$sentence .= ", bananas"; // using concatenating assignment operator
echo $sentence;

$sentence .= ", cucumbers";
echo $sentence;

//prints:

Output-only Terminal
Output:
I'm going on a picnic!
I'm going on a picnic, and I'm taking apples
I'm going on a picnic, and I'm taking apples, bananas
I'm going on a picnic, and I'm taking apples, bananas, cucumbers


ASSIGN BY REFERENCE 
A new variable holds a copy of the value held by the original variable, but it's an independent
entity; changes made to either variable won't affect the other. 

example:
$first_player_rank = "Beginner"; 
$second_player_rank = $first_player_rank; 
echo $second_player_rank; // Prints: Beginner

$first_player_rank = "Intermediate"; // Reassign the value of $first_player_rank
echo $second_player_rank; // Still Prints: Beginner

we can also create an alias or nickname for a variable. Instead of a copy of the original variable's value. 
We use a different operator (=&)
However, changes made to one variable will affect the other:

$first_player_rank = "Beginner";
$second_player_rank =& $first_player_rank; 
echo $second_player_rank; // Prints: Beginner

$first_player_rank = "Intermediate"; // Reassign the value of $first_player_rank
echo $second_player_rank; // Prints: Intermediate

<?php
/* Imagine a lot of code here */  
  $very_bad_unclear_name = "15 chicken wings";

// Write your code here:
$order =& $very_bad_unclear_name;
$order .= $very_bad_unclear_name;

  // Don't change the line below
  echo "\nYour order is: $very_bad_unclear_name.";

  // prints: Your order is: 15 chicken wings15 chicken wings.