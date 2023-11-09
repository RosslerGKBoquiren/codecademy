// function Expressions - function inside an expression; function name is omitted.
// Create a variable named plantNeedsWater using the const variable keyword.
// Assign an anonymous function that takes in a parameter of day to plantNeedsWater
const plantNeedsWater = function(day) {
    if(day === 'Wednesday') {
  // if conditional checks day === 'wednesday' should return true
      return true;
    } else {
  // else statement returns false
      return false;
    }
  };
  // log argument 'Tuesday'; if correct - the log will print false
  console.log(plantNeedsWater('Tuesday'));
  // output false
  