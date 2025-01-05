<?php
$question = magic8Ball();

$choice = rand(1, 20); // generate a random integer for the 20 options

function magic8Ball() // define function
{
  echo "Tell me... What is your question?\n";  
  $question = readline("> ");   // save question into variable
  return $question;
}

echo "\nHmm I see... Your question is $question... I understand why this weighs on you... I have consulted the spirit world.\nHere is your answer: "; 

switch($choice) {
  case 1:
    echo "It is certain.";
    break;
  case 2:
    echo "It is decidedly so.";
    break;
  case 3:
    echo "Without a doubt.";
    break;
  case 4:
    echo "Yes - definitely.";
    break;
  case 5:
    echo "You may rely on it.";
    break;
  case 6:
    echo "As I see it, yes.";
    break;
  case 7:
    echo "Most likely.";
    break;
  case 8:
    echo "Outlook good.";
    break;
  case 9:
    echo "Yes.";
    break;
  case 10:
    echo "Signs point to yes.";
    break;
  case 11:
    echo "Reply hazy, try again.";
    break;
  case 12:
    echo "Ask again later.";
    break;
  case 13:
    echo "Better not tell you now.";
    break;
  case 14:
    echo "Cannot predict now.";
    break;
  case 15: 
    echo "Concentrate and ask again.";
    break;
  case 16: 
    echo "Don't count on it.";
    break;
  case 17:
    echo "My reply is no.";
    break;
  case 18:
    echo "My sources say no.";
    break;
  case 19:
    echo "Outlook not so good.";
    break;
  case 20:
    echo "Very doubtful.";
    break; 
}

