IF STATEMENTS
<?php
namespace Codecademy;

function markAnswer($bool)
{
  if($bool) {
    return "green";
  } else {
    return "red";
  }
}

echo markAnswer(True); // green
echo "\n";
echo markAnswer(False); // red


COMPAISON OPERATORS
<?php
namespace Codecademy;

function chooseCheckoutLane($num)
{
  if ($num <= 12) {
    return "express lane";
  } else {
    return "regular lane";
  }
}

echo chooseCheckoutLane(4); // express lane
echo "\n";
echo chooseCheckoutLane(14); // regular lane

function canIVote($age)
{
  if ($age >= 18) {
    return "yes";
  } else {
    return "no";
  }
}

echo "\n";
echo canIVote(18); // yes
echo "\n";
echo canIVote(17); // no


IDENTICAL AND NOT IDENTICAL OPERATORS
<?php
namespace Codecademy;
function agreeOrDisagree($str1, $str2) 
{
  if ($str1 === $str2) {
    return "You agree!";
  } else {
    return "You disagree!";
  }
}

echo agreeOrDisagree('Jay', 'Jay'); // You agree!
echo "\n";
echo agreeOrDisagree('Lo', "lo"); // You disagree!

function checkRenewalMonth($str)
{
  $current_month = date("F");
  if ($str !== $current_month) {
    return "Welcome!";
  } else {
    return "Time to renew";
  }
}

echo "\n";
echo checkRenewalMonth("January"); // Welcome!
echo "\n";
echo checkRenewalMonth("April"); //Time to renew


ELSIF STATEMENT 
<?php
namespace Codecademy;

function whatRelation($percentage)
{
  if ($percentage === 0) {
    echo "not genetically related";
  } elseif ($percentage >= 1 && $percentage <= 2) {
    echo "third cousins";
  } elseif ($percentage >= 3 && $percentage <= 5) {
    echo "second cousins";
  } elseif ($percentage >= 6 && $percentage <= 13) {
    echo "first cousins";
  } elseif ($percentage >= 14 && $percentage <= 34) {
    echo "grandparent and grandchild, aunt/uncle and niece/nephew, or half siblings";
  } elseif ($percentage >= 35 && $percentage <= 99) {
    echo "parent and child or full siblings";
  } else {
    echo "identical twins";
  }
}


echo whatRelation(0); // not genetically related
echo "\n";
echo whatRelation(1); // third cousins
echo "\n";
echo whatRelation(8); // first cousins
echo "\n";
echo whatRelation(32); // grandparent and grandchild, aunt/uncle and niece/nephew, or half siblings
echo "\n";
echo whatRelation(80); // parent and child or full siblings
echo "\n";
echo whatRelation(100); // identical twins
echo "\n";



SWITCH STATEMENT 
<?php
namespace Codecademy;
function airQuality($color) 
{
  switch ($color) {
    case "green":
      echo "good";
      break; 
    case "yellow":
      echo "moderate";
      break; 
    case "orange":
      echo "unhealthy for sensitive groups";
      break; 
    case "red":
      echo "unhealthy";
      break; 
    case "purple":
      echo "very unhealthy";
      break; 
    case "maroon":
      echo "hazardous";
      break; 
    default:
      echo "invalid color";
  }
}

echo airQuality('green'); // good
echo "\n";
echo airQuality('yellow'); // moderate
echo "\n";
echo airQuality('orange'); // unhealthy for sensitive groups
echo "\n";
echo airQuality('red'); // unhealthy
echo "\n";
echo airQuality('purple'); // very unhealthy
echo "\n";
echo airQuality('maroon'); // hazardous
echo "\n";
echo airQuality('blue'); // invalid color
echo "\n";



SWITCH STATEMENTS FALL THROUGH
<?php
namespace Codecademy;

function returnSeason($month)
{
  switch ($month) {
    case 'December':
    case 'January':
    case 'February':
      return 'winter';
      break;
    case 'March':
    case 'April':
    case 'May':
      return 'spring';
      break;
    case 'June':
    case 'July':
    case 'August':
      return 'summer';
      break;
    case 'September':
    case 'October':
    case 'November':
      return 'fall';
      break;
  }
}


TERNARY OPERATOR 
<?php
namespace Codecademy;

function ternaryCheckout($num)
{
  return $num <= 12 ? "express lane" : "regular lane";
}

function ternaryVote($age)
{
  return $age >= 18 ? "yes" : "no";
}


echo ternaryCheckout(8); // express lane
echo "\n";
echo ternaryCheckout(13); // regular lane
echo "\n";
echo ternaryVote(17); // no
echo "\n";
echo ternaryVote(19); // yes


TRUTHY AND FALSY
<?php
namespace Codecademy;

function truthyOrFalsy($trueFalse)
{
  if ($trueFalse) {
    return "True";
  } else {
    return "False";
  } 
}

echo truthyOrFalsy(""); // False
echo "\n";
echo truthyOrFalsy("Yes"); // True


USER INPUT: READLINE()
<?php
namespace Codecademy;

echo "Hello, there. What's your first name?\n";
$name = readline(">> ");

$name_length = strlen($name);

if ($name_length > 8) {
  echo "Hi, ${name}. That's a long name.";
} elseif ($name_length > 3) {
  echo "Hi, ${name}.";
} else {
  echo "Hi, ${name}. That's a short name.";
}




REVIEW
<?php
$gryffindor = 0;
$hufflepuff = 0;
$ravenclaw = 0;
$slytherin = 0;

//$answer1, $answer2, $answer3;

echo  "================\nThe Sorting Hat!\n================\n\n";


  // ~~~~~~~~~~ Question 1 ~~~~~~~~~~

  echo "Q1) When I'm dead, I want people to remember me as:\n\n  1) The Good\n  2) The Great\n  3) The Wise\n  4) The Bold\n\nEnter your answer (1-4): ";
  
  

  $answer1 = readline(">>");

  if ($answer1 === "1")
    $hufflepuff++;
  elseif ($answer1 === "2")
    $slytherin++;
  elseif ($answer1 === "3")
    $ravenclaw++;
  elseif ($answer1 === "4")
    $gryffindor++;

  // ~~~~~~~~~~ Question 2 ~~~~~~~~~~

  echo "\nQ2) Dawn or Dusk?\n\n  1) Dawn\n  2) Dusk\n\nEnter your answer (1-2): ";

  $answer2 = readline(">>");

  if ($answer2 === "1") 
  {
    
    $gryffindor++;
    $ravenclaw++;
  
  } 
  elseif ($answer2 === "2") 
  {

    $hufflepuff++;
    $slytherin++;

  }
  else 
  {

    echo "Invalid input\n";

  }

  // ~~~~~~~~~~ Question 3 ~~~~~~~~~~

  echo "\nQ3) Which kind of instrument most pleases your ear?\n\n  1) The violin\n  2) The trumpet\n  3) The piano\n  4) The drum\n\nEnter your answer (1-4): ";

  $answer3 = readline(">>");

  if ($answer3 === "1")
    $slytherin++;
  elseif ($answer3 === "2")
    $hufflepuff++;
  elseif ($answer3 === "3")
    $ravenclaw++;
  elseif ($answer3 === "4")
    $gryffindor++;

  // ~~~~~~~~~~ Question 4 ~~~~~~~~~~

  echo "\nQ4) Which road tempts you the most?\n\n  1) The wide, sunny grassy lane\n  2) The narrow, dark, lantern-lit alley\n  3) The twisting, leaf-strewn path through woods\n  4) The cobbled street lined (ancient buildings)\n\nEnter your answer (1-4): ";

  $answer4 = readline(">>");

  if ($answer4 === "1")
    $hufflepuff++;
  elseif ($answer4 === "2")
    $slytherin++;
  elseif ($answer4 === "3")
    $gryffindor++;
  elseif ($answer4 === "4")
    $ravenclaw++;
  
  // ========== Sorting ==========

  echo "Congrats on being sorted into... ";

  $max = 0;
  $house = "";

  if ($gryffindor > $max) 
  {

    $max = $gryffindor;
    $house = "Gryffindor";
    
  }

  if ($hufflepuff > $max) 
  {

    $max = $hufflepuff;
    $house = "Hufflepuff";

  }
  
  if ($ravenclaw > $max) 
  {

    $max = $ravenclaw;
    $house = "Ravenclaw";

  }
  
  if ($slytherin > $max) 
  {

    $max = $slytherin;
    $house = "Slytherin";

  }
  
  echo $house . "!\n";


