PHP in HTML

<html>
<body>
<h1>PHP and HTML</h1>
<p>This is HTML</p>
<?php echo "<p>This is PHP</p>";?>
</body>
</html>


BEYOND STRINGS
<?php 
$about_me = [
  "name" => "Aisle Nevertell",
  "birth_year" => 1902,
  "favorite_food" => "pizza"
];

function calculateAge ($person_arr){
  $current_year = date("Y");
  $age = $current_year - $person_arr["birth_year"];
  return $age;
}
?>
<h1>Welcome!</h1>
<h2>About me:</h2>
<?php
#Add your code here
echo "<h3>My name is ${about_me['name']}</h3>";
echo "<p>I am " . calculateAge($about_me) . " years old.</p>";
echo "<div>My favorite food is ${about_me['favorite_food']}!</div>";
?>
 
<h2>Now tell me a little about you.</h2>


SHORTHAND FOR FOR-LOOPS
<h1>Only Shoes Shoe Shop</h1>
<?php
for ($i = 0; $i < 5; $i++):
?>
<p>We sell shoes</p>
<?php
endfor;
?>

LOOP SHORTHAND WHILE AND FOREACH LOOPS
<ul>
<?php
$i = 0;
while ($i < 2):
?>
<li>Duck</li>
<?php
$i++;
endwhile; // endwhile for while loops
?>
<li>Goose</li>
</ul>


<ul>
<?php
$array = [0, 1];
foreach ($array as $i):
?>
<li>Duck</li>
<?php
endforeach; // endforeach for for each loop
?>
<li>Goose</li>
</ul>


<h1>Only Shoes Shoe Shop</h1>
<?php
$i = 0;
$repeats = [0, 1];
while ($i < 5): // endwhile
?>
<p>We sell shoes</p>
  <?php
  foreach ($repeats as $value): //endforeach
  ?>
  <p>(only shoes)</p>
  <?php
  endforeach;
  ?>
<?php
  $i++;
endwhile;
?>

CODE BLOCK CONSIDERATIONS
<h1>Shoe Shop</h1>
<?php
$footwear = [
  "sandals" => 4,
  "sneakers" => 7,
	"boots" => 3
];
?>
<p>Our footwear:</p>
<?php
foreach ($footwear as $type => $brands):
?>
<p>We sell <?=$brands?> brands of <?=$type?></p> // echo shorthand <?=$str?>

<?php
endforeach;
?>



WORKING WITH VARIABLES
gettype() function 
var_dump() function

<?php
namespace Codecademy;

$first = "Welcome to the magical world of built-in functions.";
  
$second = 82137012983; 

//Write your code below:
echo gettype($first); // prints: string
echo "\n";
echo gettype($second); // prints: integer
echo "\n";
var_dump($first); // prints: string(51) "Welcome to the magical world of built-in functions."
echo "\n";
var_dump($second); // prints: int(82137012983)


STRING FUNCTIONS 
strrev() // string reverse
strtolower() // string to lower
str_repeat() // string repeat

<?php
namespace Codecademy;

// Write your code below:
echo strrev(".pu ti peeK .taerg gniod er'uoY"); // You're doing great. Keep it up.

echo strtolower("SOON, tHiS WILL Look NoRmAL."); // soon, this will look normal.

echo str_repeat("\nThere's no place like home.\n", 3);
/* 
There's no place like home.

There's no place like home.

There's no place like home.
*/

WORKING WITH SUBSTRINGS
substr_count($str, 'string') function // how many time 'string' appears in $story  

<?php
namespace Codecademy;

$essay_one = "I really enjoyed the book. I thought the characters were really interesting. The plot of the novel was really engaging. I really felt the characters' emotions. They were really well-written. I really wish the ending had been different though.";
  
$essay_two = "Obviously this is a really good book. You obviously would not have made us read it if it wasn't. I felt like the ending was too obvious though. It was so obvious who did it right away. I think the thing with the light was obviously a metaphor for life. It would have been better if the characters were less obvious about their secrets.";  

// Write your code below:
echo substr_count($essay_one, 'really'); // prints: 6
echo substr_count($essay_two, 'obvious'); // 5


NUMBER FUNCTIONS 
abs() // absolute value 
round() // return nearest integer

<?php
namespace Codecademy;

// Write your code below:
function calculateDistance($param1, $param2)
{
  return abs($param1 - $param2);
};

function calculateTip($meal)
{
  return round($meal * 1.18);
};

echo calculateDistance(-1, 4); // 5
echo "\n";
echo calculateDistance(4, -1); // 5
echo "\n";
echo calculateDistance(3, 7); // 4
echo "\n";
echo calculateDistance(7, 3); // 4
echo "\n";
echo calculateTip(100); // 118
echo "\n";
echo calculateTip(35); // 41
echo "\n";
echo calculateTip(88.77);  // 105
echo "\n";


GENERATING RANDOM NUMBERS
rand() // random integer

$max = getrandmax();
echo $max;
echo rand(); // prints a number between 0 and declared variable 

<?php
namespace Codecademy;

// Write your code below:
$max = getrandmax();
echo $max;
echo rand(); // 21474836471619788200

echo "\n";
echo rand(1, 52); // 10, could also be anything between 1 and 52


DOCUMENTATION 
<?php
namespace Codecademy;

$a = 29;
$b = "You did it!";
$c = STR_PAD_BOTH;
$d = "*~*";

// Write your code below:
echo str_pad($b, $a, $d, $c);


FINDING FUNCTIONS 
<?php
namespace Codecademy;

// Write your code below:
function convertToShout($str)
{
  return strtoupper($str) . "!";
}

echo convertToShout("woah there, buddy"); // WOAH THERE, BUDDY!

function tipGenerously($cost)
{
  return ceil($cost * 1.20);
}

echo "\n";
echo tipGenerously(100.00); // 120


function calculateCircleArea($r)
{
  return pi() * ($r/2) ** 2;
}

echo "\n";
echo calculateCircleArea(25); //490.87385212341


<?php
$string_var = "Check it out";
echo strtoupper($string_var) . "!\n";

echo ceil(8.873);
echo "\n";
  
echo pi();
echo "\n";

echo str_pad("PHP", 30, "*^*-", STR_PAD_BOTH);
echo "\n";

echo getrandmax();
echo "\n";

echo rand();
echo "\n";

echo rand(1, 52);
echo "\n";

echo abs(-1287);
echo "\n";

echo round(8723.999);
echo "\n";

echo substr_count($string_var, " ");
echo "\n";

echo strrev("\n.pu ti peeK .taerg gniod er'uoY");

echo strtolower("SOON, tHiS WILL Look NoRmAL.\n");

echo str_repeat("There's no place like home.\n", 3);

echo gettype($string_var);
echo "\n";
echo var_dump($string_var);