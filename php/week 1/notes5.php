CREATING ARRAYS with array()
we can construct ordered arrays with a built-in PHP function: array()

array() function returns an array. Each of the arguments with which the function was called becomes
an element in the array in the order they were passed in. 
Arrays are most useful when we store them in variables. 

$my_array = array(0, 1, 2);


PHP arrays can store elements of any data type:
$string_array = array('first element', 'second element');


PHP arrays can also store elements of multiple data types:
$mixed_array = array(1, 'chicken', 78.2, 'bubbles are crazy!');

<?php
// Write your code below:
$first_array = array('Jason', 8, 'Todler', 51.3, 'small');
echo count($first_array); //prints: 5


CREATING ARRAYS WITH SHORT SYNTAX
in addition to using array(), we can also create an array by wrapping comma-separated elements in square brackets[]. This feature is sometimes reffered to as short array syntax. and more closely resembles what you might see in other programming languages. 

$number_array = [0, 1, 2];

$string_array = array('first element', 'second element');
$str_arr_short = ['first element', 'second element'];

regardless of the method used, we get the same results. 

<?php
namespace Codecademy;

// Write your code below:
$with_function = array('PHP', 'popcorn', 555.55);
$with_short = ['PHP', 'popcorn', 555.55];


PRINTING ARRAYS 
since arrays are a more complicated data type than strings or integers, printing them is slightly more challenging. Using echo won't have the desired result:

$number_array = [0, 1, 2]
echo $number_array; //Prints: Array 

when we tried to print the array, the printed the word 'Array' rather than its contents. 
To fix this, we need to use the PHP built-in function 'print_r()'

print_r($number_array);
//prints: 
Array
(
	[0] => 0
	[1] => 1
	[2] => 2
)

if we merely want to print the elements in the array listed, we use the built-in 'implode()'
this function takes two arguments: a string (the $glue) and the array to be joined (the $spieces)

echo implode(', ', $number_array);
//prints: 0, 1, 2

<?php
namespace Codecademy;

$message = ["Oh hey", " You're doing great", " Keep up the good work!\n"];

$favorite_nums = [7, 201, 33, 88, 91];
// Write your code below:
echo implode('!', $message);
print_r($favorite_nums);
/* prints:
Oh hey! You're doing great! Keep up the good work!
Array
(
    [0] => 7
    [1] => 201
    [2] => 33
    [3] => 88
    [4] => 91
) */


ACCESSING AN ELEMENT
the individual elements in an array can be access using the array variable's name, and the location index surrounded by square brackets []

$my_array = ['tic', 'tac', 'toe'];
echo $my_array[1]; // Prints: tac

This is also referred to as indexing an array.  

Let’s look at an example of indexing an array with a number variable:

$num_var = 2;
$important_info = ["talking chicken", 181, "magnets?!", 99];
echo $important_info[$num_var]; //Prints: magnets?!

<?php
namespace Codecademy;

$round_one = ["X", "X", "first winner"];

$round_two = ["second winner", "X", "X", "X"];

$round_three = ["X", "X", "X", "X", "third winner"];

// Write your code below:
$winners = [$round_one[2], $round_two[0], $round_three[4]];
echo implode(', ', $winners);
//prints: first winner, second winner, third winner


ADDING AND CHANGING ELEMENTS
we can make adjustments to existing arrays - we don't have to create a new array when we want our array to change. 
We add elements to the end of an array by taking a variable name and appending square brackets [] 
the assignment operator = and the element we want to add. 

$string_array = ["first element", "second element"];

$string_array[] = "third element";

echo implode(", ", $string_array); 
// Prints: first element, second element, third element 

$string_array = ["first element", "second element", "third element"];

$string_array[0] = "NEW! different first element";

echo $string_array[0]; // Prints: NEW! different first element"

<?php
namespace Codecademy;

$change_me = [3, 6, 9];
// Write your code below:
$change_me[] = 'twlve'; //  add a string element to the end of the array

$change_me[] = 15; // Add another element

$change_me[1] = 'tadpole'; // Reassign the 1st index location of the array to 'tadpole'

echo implode(', ', $change_me); //prints: 3, tadpole, 9, twlve, 15 


MORE ARRAY METHODS: PUSHING AND POPPING

array_pop() function REMOVES THE LAST ELEMENT of an array and returns the removed element. 
array_push() function adds an element to the end of the array and returns the new number of the element  
<?php
namespace Codecademy;

$stack = ["wild success", "failure", "struggle"];
// Write your code below:

array_push($stack, 'blocker', 'impediment'); // add two elements to the array
array_pop($stack);
array_pop($stack);
array_pop($stack);
array_pop($stack); // remove all but one element from the array


SHIFTING AND UNSHIFTING
array_shift() function removes the first element and returns that value. 
array_unshift() function adds an element in the beginning of the array then returns the new number of elements
<?php
namespace Codecademy;
$record_holders = [];
// Write your code below:

array_unshift($record_holders, "Tim Montgomery",
"Maurice Greene", "Donovan Bailey", "Leroy Burrell", "Carl Lewis");

array_shift($record_holders);
array_unshift($record_holders, "Justin Gatlin", "Asafa Powell");

array_shift($record_holders);

array_unshift($record_holders, "Usain Bolt");


NESTED ARRAYS 
arrays can hold elements of any type, this includes other arrays. 
$nested_arr = [[2, 4], [3, 9], [4, 16]];
$first_el = $nested_arr[0][0];
echo $first_el; // Prints: 2


<?php
namespace Codecademy;


$treasure_hunt = ["garbage", "cat", 99, ["soda can", 8, ":)", "sludge", ["stuff", "lint", ["GOLD!"], "cave", "bat", "scorpion"], "rock"], "glitter", "moonlight", 2.11];
  
// Write your code below:
echo $treasure_hunt[3][4][2][0];
// prints: GOLD!