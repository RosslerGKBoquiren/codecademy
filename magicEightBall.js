// create a variable 'userName, and set variable to the user's name
let userName = "Ross";
// create a ternary expression that decides what to do if the user enters a name or not
userName ? console.log(`Hello, ${userName}!`) : console.log("Hello!");
// create a variable 'userQuestion' and add a string value asking a question
const userQuestion = "Should I cook tonight?";
// log the variable userQuestion
console.log(`${userQuestion}`);
// generate a random number between 0 and 7
const randomNumber = Math.floor(Math.random() * 8);
// create another variable eigthBall, set to empty string.
let eightBall = "";
// create control flow taking the randomNumber and then assigns eigthBall to a reply
switch (randomNumber) {
  case 0:
    eightBall = "It is certain";
    break;
  case 1:
    eightBall = "It is decidedly so";
    break;
  case 2:
    eightBall = "Reply hazy try again";
    break;
  case 3:
    eightBall = "Cannot predict now";
    break;
  case 4:
    eightBall = "Do not count on it";
    break;
  case 5:
    eightBall = "My sources say no";
    break;
  case 6:
    eightBall = "Outlook not so good";
    break;
  case 7:
    eightBall = "Signs point to yes";
    break;
  default:
    eightBall = "Hmm... Try again";
}
// log the Magic Eight Ball's answer
console.log(`The Magic Eight Ball says: ${eightBall}`);
