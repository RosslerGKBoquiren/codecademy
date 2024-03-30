<?php
function generateStory($singular_noun, $verb, $color, $distance_unit) // define function with 3 param
{
  $story = "The ${singular_noun} are lovely, ${color}, and deep \n but I have promises to keep, \n And ${distance_unit} to go before I ${verb}, \n And ${distance_unit} to go before I sleep.\n"; // assign last stanza to variable
  return $story; // return the story
}

echo generateStory("boys", "eat", "green", "km"); // three separate invocations of the function
echo generateStory("girls", "shoot", "blue", "mm");
echo generateStory("dogs", "bark", "yellow", "cm");

/* prints:
The boys are lovely, green, and deep 
 but I have promises to keep, 
 And km to go before I eat, 
 And km to go before I sleep.
The girls are lovely, blue, and deep 
 but I have promises to keep, 
 And mm to go before I shoot, 
 And mm to go before I sleep.
The dogs are lovely, yellow, and deep 
 but I have promises to keep, 
 And cm to go before I bark, 
 And cm to go before I sleep. */