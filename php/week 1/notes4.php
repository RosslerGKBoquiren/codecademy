DEFINING FUNCTIONS
create our first function:

function greetLearner() // start with [function], then its name [greetLearner]
{
	echo "Hello, Learner!\n";
	echo "I hope you're enjoying PHP!\n";
	echo "Love, Codecademy"; // these are the three instructions to perform when the function is called
}

<?php
// Write your code below:

function praisePHP () //define function named praisePHP
{
  echo "PHP is so cool!"; //add at least one echo statement
}


INVOKING FUNCTIONS 
to actually execute a functio, we need to invoke or call it. 
example:

function greetLearner() // start with [function], then its name [greetLearner]
{
	echo "Hello, Learner!\n";
	echo "I hope you're enjoying PHP!\n";
	echo "Love, Codecademy"; // these are the three instructions to perform when the function is called
}

greetLearner(); // invoking or calling the function
/* prints: 
Hello, Learner!
I hope you're enjoying PHP!
Love, Codecademy
*/

<?php
// Write your code below:
function inflateEgo() // define function
{
  echo "You are so smart!"; //statement
}

inflateEgo(); //calling the function
inflateEgo();


RETURN STATEMENTS
as the functions becomes more complicated, we often be using them to process data. Functions have the ability to return a value in addition to performing instructions. 
example:
function countdown() 
{
  echo "4, 3, 2, 1, ";
  return "blastoff!";
}

when the function countdown() is called, it will print 4,3,2,1 but what about the string 'blastoff!'?
This value will be returned. 

<?php

// Write your code below:

function printStringReturnNumber()
{
  echo "This is a string."; // prints a string
  return 42; // returns a number value
}

$my_num = printStringReturnNumber(); // capture function in a variable

echo $my_num; // print variable


MORE ON RETURN STATEMENTS 
the keyword [return] immediately stops a function. A code after [return] won't run. 

Let’s compare two different functions: announceRunning() and announceRunning2()

function announceRunning() // define function
{
  echo "The first function is running!\n";
  return "This is the return value of the first function.";
}

$first_result = announceRunning(); // define variable and assign the results of calling the function 
echo $first_result;

//Prints:
The first function is running!
This is the return value of the first function.


Let’s contrast that to the following example:
function announceRunning2()
{
  return "This is the return value of the second function."; // function stops here!
  echo "P.S., I love you";
}

$second_result = announceRunning2();
echo $second_result;

// prints:
This is the return value of the second function.


<?php

function notFound()
{
  echo "ERROR: Page not found!\n";
  return 404;
}

function greetLearner()
{
  echo "Hello, Learner!\n";
  echo "I hope you're (still) enjoying PHP!\n";
  echo "Love, Codecademy\n";
  return "<3";
}

// Don't change the code below:

$error = notFound(); 
$heart = greetLearner();

echo "I received a $error, but it's ok because I also received $heart.";

//prints:
ERROR: Page not found!
Hello, Learner!
I hope you're (still) enjoying PHP!
Love, Codecademy
I received a 404, but it's ok because I also received <3.


RETURN VALUES
a value returned from a function just that - a value. It means, it cannot be used in any
manner we would normally use a value of that type. 
Take a look at the following code:

function returnFive()
{
	return 5;
}

echo returnFive(); //Prints: 5. we have to use echo to print the invoked function. 


example with numbers and variables

echo 5 + 3; //prints: 8
$num = 5;
echo $num + 3; // prints: 8
echo returnFive() + 3; // prints: 8

a computer evaluates 5 + 3 to 8 in the same manner when a computer encounters a function - it will execute the code and then evaluate to the function's returned value. 

<?php
function first()
{
  return "You did it!\n";
}

function second()
{
  return "You're amazing!\n";
}

function third()
{
  return "You're a coding hero!\n";
}

// Write your code below:

echo first() . second() . third(); /* print the return values of each functions in order. You many not use more than one of code or more than a single statement. */

// prints: 
You did it!
You're amazing!
You're a coding hero!


RETURNING NULL 
what about functions without return statements? any function without a return, returns a value NULL. 
NULL stands for the absence of a value. 

example: 

function returnNothing() // define function
{
	echo "I'm running! I'm running!\n";
}

$result = returnNothing(); //Prints: I'm running! I'm running! // defined variable and assigned value of function when we invoked it
echo $result; // NULL because the function doesn't have a return statement. There is no value to assign. 


PARAMETERS 
Functions do exactly the same thing every time they run can save us from having to repeat code in our programs, but functions can do more. 
We can also define PARAMETERS. A parameter is a variable which serves as a placeholder throughout the funcion's code block. When the function is invoked, it's invoked with a specific value. As the computer executes the function, it replaces each occurence of the parameter with the value that was passed in. The actual value passed in is known as an argument. 

example:

function sayCustomHello($name) // $name is the parameter
{
	echo "Hello, $name!";
};

sayCustomHello("Aisle Nevertell"); //Prints; Hello, Aisle Nevertell! 
sayCustomeHello("Codecademy learner"); //Prints: Hello, Codecademy learner

<?php
// Write your code below:
function increaseEnthusiasm($param) // define function
{
  return $param . "!"; // return parameter with an exclamation mark
};

echo increaseEnthusiasm("Hey");

function repeatThreeTimes($str) // define function
{
  return $str . $str . $str; // repeat parameter 3x
}

echo repeatThreeTimes("LOL"); // print the result of previous function

echo increaseEnthusiasm(repeatThreeTimes("This is sorcery!")); /* print the result of invoking your increaseEnthusiasm() with the result of invoking repeatThreeTimes() as the argument passed into increaseEnthusiasm(). You can choose any string you like for the argument to repeatThreeTimes() */

//prints: Hey!LOLLOLLOLThis is sorcery!This is sorcery!This is sorcery!!


MULTIPLE PARAMETERS 
we can also define functions with multiple parameters 

example:
function divide($num_one, $num_two)
{
	return $num_one / $num_two;
};

It takes in two number arguments and returns the result of dividing the first parameter by the second. 

echo divide(12, 3); //Prints: 4
echo divide(3, 12); //Prints: 0.25


<?php
// Write your code below:
function calculateArea($height, $weight)
{
  return $height * $weight;
};

echo calculateArea(12, 5); //Prints: 60

function calculateVolume($height, $width, $depth)
{
  return $height * $width * $depth;
};

echo calculateVolume(5, 6, 2); //prints: 6060


DEFAULT PARAMETERS 
what is no argument is passed?
we can accomplish this by providing a default value for the $name paramater 

exmple: 
function greetFriend($name = "old chum") // default parameter "old chum"
{
	echo "Hello, $name!";
};

greetFriend("Marvin"); // Prints: Hello, Marvin!
greetFriend(); // Prints: Hello, old chum!

<?php
// Write your code below:
function calculateTip($meal, $tip = 20)
{
  $tipAmount = $meal * ($tip/100);
  $total = $meal + $tipAmount;
  return $total;
};

echo calculateTip(100);
echo "\n";
echo calculateTip(100, 25);

// prints: 
120
125


PASS BY REFERENCE
we can invoke functions with variables or with values directly. It's as if we're assigning the value held by that vairable to the function's parameter. We assign a copy of the value held by the argument variable. The variable argument and the parameter are distinct entities; changes made inside the function to the parameter will not affect the variable that was passed in. 

function addX($param) // define function 
{
	$param = $param . "X";
	echo $param;
};
$word = "Hello"; // defined varibale
addX($word); //Prints: HelloX // used the variable as an argument 
echo $word; //Prints: Hello 

If we do want to make permanent changes to a variable with a function, we can prepend the parameter name with the reference sign (&). This way, we assign the parameter to be an alias for the argument variable. Both will refer to the same spot in memory and changes to the parameter within the function will permanently affect the argument variable.  

function addXPermanently (&$param)
{
	$param = $param . "X";
	echo $param;
};
$word = "Hello";
addXPermanently($word); //Prints: HelloX
echo $word; //Prints: HelloX // it changed both the parameter and the variable values 

<?php

$string_one = "you have teeth";
$string_two = "toads are nice";
$string_three = "brown is my favorite color";

// Write your code below:
function convertToQuestion(&$str)
{
  $str = "Do you think " . $str . "?\n";
};

convertToQuestion($string_one);

convertToQuestion($string_two);

convertToQuestion($string_three);


echo $string_one;
echo $string_two;
echo $string_three;

/* prints:
Do you think you have teeth?
Do you think toads are nice?
Do you think brown is my favorite color?
*/


VARIABLE SCOPE
This is the preferred method of exchanging information within a program since it is straightforward to see the data a function depends on from the function parameter list.

function calculateDaysLeft($feed_quantity, $number, $rate)
{
	$result = $feed_quatity / ($number * $rate);
	return $result; 
}
echo calculateDaysLeft(300, 2, 30);
echo $result; //prints: undefined variable because the variable is within a local scope and can only be accessed within the code block itself. 

However, if many functions depend on the same piece of information, it can be beneficial to have a variable that can be accessed anywhere without being passed in. To do this we have to use the [global] keyword to tell php to look in the global scope for the variable instaead of the local scope of the function. 

$feed_quantity = 300;
function calculateDaysLeft($number, $rate)
{
	global $feed_quantity;
	$result = $feed_quantity / ($number * $rate);
	return $result;
}
echo calculateDaysLeft(2, 120);

with this pattern, it becomes slighlty more difficult to determine what information this function depends on. Note that the global keyword is not used when invoking functions. Once a function has been defined, it can be used within the same code block or even wtihin other function code blocks. 

<?php

$language = "PHP";
$topic = "scope";

function generateLessonName($concept) // removed $language from parameter
{
  global $language; // created global $language
  return $language . ": " . $concept;
}

echo generateLessonName($topic);
//prints: PHP: scope