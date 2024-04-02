ASSOCIATIVE ARRAYS
associative arrays are collections of key => value pairs. The key in an associative array must be either a string or an integer. 
we think of keys as pointing to their values since the key points the computer to the space in memory where the value is stored. 

$my_array = ['panda' => 'very cute', 'lizard' => 'cute', 'cockroach' => 'not very cute'];

in the code above, we created an associative array using short array syntax. $my_arrray has three key => value pairs:

the key 'panda' points to the value 'very cute'
the key 'lizard' points to the value 'cute'
the key 'cockroach' points to the value 'not very cute'

we can also build associative arrays using the PHP array() function

$about_me = array(
	'fullname' => 'Aisle Nevertell',
	'social' => 123456789
);

<?php
namespace Codecademy;

// Write your code below:
$php_array = array(
  'language' => 'PHP',
  'creator' => 'Rasmus Lerdorf',
  'year_created' => 1995,
  'filename_extensions' => ['.php', '.phtml', ".php3", ".php4", ".php5", ".php7", ".phps", ".php-s", ".pht", ".phar"]
);

$php_short = ['language' => 'PHP', 'creator' => 'Rasmus Lerdorf', 'year_created' => 1995, 'filename_extensions' => ['.php', '.phtml', ".php3", ".php4", ".php5", ".php7", ".phps", ".php-s", ".pht", ".phar"]]; //short array syntax


PRINTING ASSOCIATIVE ARRAYS 
using echo to print arrays is not very useful because it will print: Array. 

so we use echo implode() to print the array into a single string.
echo implode(', ', $grades); //Prints: 98, 74, 88

A problems with echo implode() is that it only displays the values and we don't see the keys in the array of the relationships between the keys and values. 
To display this information, we can use the built-in print_r() function:

print_r($grades);

The above code will produce the following output:

Array (
	[Jane] => 98
	[Lily] => 74
	[Dan] => 88
)


<?php
namespace Codecademy;

// Write your code below:
$september_hits = [
  'The Sixth Sense' => 22896967,
  'Stigmata' => 18309666,
  'Blue Streak' => 19208806,
  'Double Jeopardy' => 23162542
]; //using the short version of associative arrays / keys

echo implode(', ', $september_hits); //using echo implode() 22896967, 18309666, 19208806, 23162542
print_r($september_hits); // using print_r()
/*
	[The Sixth Sense] => 22896967
    [Stigmata] => 18309666
    [Blue Streak] => 19208806
    [Double Jeopardy] => 23162542
*/


ACCESSING AND ADDING ELEMENTS
we can access the value that a given key points to by using square brackets []

$my_array = ["panda"=>"very cute", "lizard"=>"cute", "cockroach"=>"not very cute"];
echo $my_array['panda']; //Prints: very cute
We access the value 'very cute' using its key 'panda'

to add new elements to an associative array, we use the assignment operator (=)

$my_array['capybara'] = 'cutest';
echo $my_array['capybara']; //prints: cutest

in the code above, we added a fourth key value pair to the array. We access the new value 'cutest' using its key 'capybara' and printed it using echo. 

The computer treats code between the square brackets as an expression, so that code will be evaluated before the array is accessed. This enables us to use variables, functions, and operators within the square brackets. 

$favorites = ["favorite_food"=>"pizza", "favorite_place"=>"my dreams", "FAVORITE_CASE"=>"CAPS", "favorite_person"=>"myself"];

echo $favorites['favorite' . '_' . 'food']; //key is favourite_food 
//prints its value: pizza

$key = 'favorite_place'; //assigns key to a variable 
echo $favorite[$key] // prints value: my dreams

echo $favorites[strtoupper('favorite_case')]; // String to Upper case the key. prints value: CAPS

<?php
namespace Codecademy;
$assignment_one = ["Alex"=> 87, "Kenny"=> 91, "Natalia"=> 91, "Lily"=> 67, "Dan"=> 81, "Kat"=> 77, "Sara" => 65];

$assignment_two = ["Alex"=> 91, "Kenny"=> 99, "Natalia"=> 100, "Lily"=> 61, "Dan"=> 88, "Kat"=> 90];

$assignment_three = ["Alex"=> 78, "Kenny"=> 92, "Natalia"=> 94, "Lily"=> 79, "Dan"=> 73, "Sara" => 61];

$student_name = "Alex";
// Write your code below:
$assignment_two['Sara'] = 65; // Sara turned in her second assignment late—she got a 65.
$assignment_three['Kat'] = 97; // Kat’s third assignment was briefly misplaced—she got a 97.

$dans_grades = [$assignment_one['Dan'], $assignment_two['Dan'], $assignment_three['Dan']];
// a new ordered array named $dans_grades which holds Dan’s grades from each of the three assignments

echo $assignment_two[$student_name]; //print the result of accessing $assignment_two with the $student_name variable


CHANGING AND REMOVING ELEMENTS
The same syntax that adds new array elements can be used to change existing elements:

$new_arr = ["first" => "I am first!", "second" => "I am second!"]; 

$new_arr["third"] = "I am third!";

echo $new_arr["third"]; // Prints: I am third! //using the key to change the value

$new_arr["third"] = "I am the *NEW* third!";

echo $new_arr["third"]; // Prints: I am the *NEW* third!


We can remove a key => value pair entirely using the PHP unset() function 
if the key does not exist then nothing happens. 

$nums = ["one" => 1,"two"=> 2];

echo implode(", ", $nums); // Prints: 1, 2

unset($nums["one"]); // unset() removed the key 'one' deleting it and its value completely. 

echo implode(", ", $nums); // Prints: 2


<?php
namespace Codecademy;

$my_car = [
  "oil" => "black and clumpy",
  "brakes" => "new",
  "tires" => "old with worn treads",
  "filth" => "bird droppings", 
  "wiper fluid" => "full", 
  "headlights" => "bright"
];
print_r($my_car);
// Write your code below:
$my_car["oil"] = "new and premium";

$my_car["tires"] = "new with deep treads";


unset ($my_car["filth"]);

print_r($my_car);


NUMERICAL KEYS
associative arrays can use integers as keys in addition to strings. 
$num_array = [1000 => "one thousand", 100 => "one hundred", 600 => "six hundred"];
echo $num_array[1000]; // Prints: one thousand

When we build ordered arrays in PHP, the association with numerical keys to values is done for us automatically. The first element is associated with the key 0, the second with 1, and so on. But ordered arrays are still the same sturcture as associative arrays.

$ordered = [99, 1, 7, 8];

$ordered['special'] = 'cool'; // adding a new key and value in the array '

echo $ordered[3]; prints: 8 // index number 3

echo $ordered['special']; // prints value: cool

When we add an element to an array without specifiying a key by using array_push(), PHP will associate it with the next integer key. If no integer keys have been used, it will associate it with the key 0. Otherwise, it will associate it one more than the largest integer used so far. If

$num_array = [1000 => "one thousand", 100 => "one hundred", 600 => "six hundred"];

$num_array[] = "New Element in \$num_array"; // provided value but no key.

echo $num_array[1001]; //prints: New Element in $num_array
// a new created was created automatically by taking the largest integer used so far and increasing it by one. 

$animals_array = ["panda"=>"very cute", "lizard"=>"cute", "cockroach"=>"not very cute"];

array_push($animals_array, "New Element in \$animals_array"); 

echo $animals_array[0]; // Prints: New Element in $animals_array

<?php
namespace Codecademy;

// Write your code below:
$hybrid_array = ['string', 5, 'str', 4, 3];
$hybrid_array[8] = 'five more';
print_r($hybrid_array);
array_push($hybrid_array, rand()); // rand() or random value
echo $hybrid_array[9];


JOINING ARRAYS 
PHP also lets us combine arrays. The union (+) operator takes two array and returns a new array with any unique keys from the second array to the first array. 

$my_array = ["panda" => "very cute", "lizard" => "cute", "cockroach" => "not very cute"];

$more_rankings = ["capybara" => "cutest", "lizard" => "not cute", "dog" => "max cuteness"];

$animal_rankings = $my_array + $more_rankings; // $my_array + $more_rankings

Since 'lizard' is not a unique key, $animal_rankings will retain the value of 'lizard' from the first array $my_array which is 'cute'


the union array can be a little trickey...
$number_array = [8, 3, 7];

$string_array = ["first element", "second element", "third element"];

$union_array = $number_array + $string_array;

What values does $union_array hold?
(8, 3, 7)
because, since the two array being joined have identical keys 0, 1, 2, 
no values from the second array, $string_array, are included in $union_array. 

<?php
namespace Codecademy;

$giraffe_foods = ["dip"=>"guacamole", "chips"=>"corn", "entree"=>"grilled chicken"];

$impala_foods = ["dessert"=>"cookies", "vegetable"=>"asparagus", "side"=>"mashed potatoes"];

$rat_foods = ["dip"=>"mashed earth worms", "entree"=>"trash pizza", "dessert"=>"sugar cubes", "drink"=>"lemon water"];

// Write your code below:

$potluck = $giraffe_foods + $impala_foods;
print_r($potluck);


ASSING BY VALUE OR BY REFERENCE 
There are two ways to assign one variable to another: 

1. by value - this creates two variables that hold copies of the same value but remain independent entities.
2. by reference - this creates two variable name which point to the same space in memory.

$favorites = ["food"=>"pizza", "person"=>"myself", "dog"=>"Tadpole"];

$copy = $favorites;

$alias =& $favorites;

$favorites["food"] = "NEW!";

echo $favorites["food"]; // Prints: NEW!
echo $copy["food"]; // Prints: pizza
echo $alias["food"]; // Prints: NEW!


when passing arrays into functions, both built-in functions and those we write ourselves, we will want to be conscious of whether the arrays are being passed by value or by reference. 

