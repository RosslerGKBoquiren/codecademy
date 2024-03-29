NUMBERS
php has two data types.
- interger includes positive and negative whole numbers
- floating point includes decimal numbers

<?php
// Write your code below:
$my_integer = 8;
echo $my_integer;

$my_float = 8.1;
echo "\n";  // its possible to print a newline on its own
echo $my_float;

//prints:
8
8.1


ADDITION and SUBTRACTION 
(+)(-)

echo 5 + 1; // Prints: 6
echo 6.6 + 1.2; // Prints: 7.8
echo 198263 - 263;  // Prints: 198000
echo -22.8 - 19.1; // Prints: -41.9


USING NUMBER VARIABLES 
we can use number operators on variables that hold number values:
$tadpole_age = 7;
$lily_age = 6; 
$age_difference = $tadpole_age - $lily_age;
echo $age_difference; // Prints 1

we can also reassign number variables using the assignment operator:
$age = 82;
echo $age; // Prints: 82

$age = $age + 2;
echo $age; // Prints: 84

<?php
// Write your code below:
  $last_month = 1187.23;
  $this_month = 1089.98;
  echo $last_month - $this_month;
  
  //Prints: 97.25


  MULTIPLICATION and DIVISION
  (*)(/)
  echo 2 * 3; // Prints: 6
echo -21 / 7; // Prints: -3

note - when we perform multiplication or division, the computer will return 
an integer whenever the operation evaluates to a whole number.
The reverse is also true - it will return a floating point number. 

<?php
// Write your code below:
  
 $num_languages = 4; 
 $months = 11; 
  
  $days = $months * 16;
  
  $days_per_language = $days / $num_languages;

echo $days_per_language; //prints: 44

EXPONENTIATION
php give us an operator for raising a number to the power of another number
(**)

example:
echo 4 ** 2; //Prints: 16

also works on floats and negative numbers
echo 2.89 ** 3.2; //prints: 29.845104015297
echo 18 ** -1; // prints: 0.1


MODULO 
(%) returns the remainder
example:
echo 7 % 3; //Prints: 1

We have 82 students going on a class trip. We want to divide the students into groups of 6. Use the modulo operator to echo how many students will be left without groups.
<?php
// Write your code below:
  
echo 82 % 6; // prints: 4


ORDER OF OPERATIONS
we can chain multiple operations together to get a single result:
echo 2 + 3 + 4 + 5 - 1.1; //prints: 12.9
echo 2 * 9 / 6; //prints: 3

operations will be evaluated in the following order:
1. ()
2. Exponents **
3. Multiplication and division * /
4. Addition and subtration + -

echo 94 - 4.25 + 7 - (23.50 + (23.50 * 0.2)) + (20 / 4);  // prints: 73.55



METHEMATICAL ASSIGNMENT OPERATORS
one common task when manipulating number variables is to reassign them to their old value with some 
operation performed on it 
$savings = 800;
$bike_cost = 75;
$savings = $savings - $bike_cost;
echo $savings; // Prints: 725

a short way to reqrite the syntax above: 
$savings = 800;
$bike_cost = 75;
$savings -= $bike_cost; // (-=)
echo $savings; //PrintsL 725

one more shortcut, increment operators allow us to subtract or add to a number with just two characters. 
$age = 89;
$age++;
echo $sage; //Prints: 90

$days_till_vacation = 7;
$days_till_vacation--;
echo $days_till_vacation; // Prints: 6

<?php
// Write your code below:

$my_num = 30;
$answer = $my_num;
$answer += 2; // add 2 to $answer
$answer *= 2; // multiply $answer by 2
$answer -= 2; // subtract 2 from $answer
$answer /= 2;  // divide $answer by 2
$answer -= $my_num; //subtract your original number from $answer
echo $answer;

// no matter what the original number was, the $answer would be = 1