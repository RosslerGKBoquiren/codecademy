console.log("Let's play Rock, Paper, Scissors!");

const getUserChoice = (userInput) => {
  const choices = ["rock", "paper", "scissors", "bomb"];
  let randomNumber = Math.floor(Math.random() * 4);
  return `Player chose ${choices[randomNumber]}`;
};

function getComputerChoice() {
  const choices = ["rock", "paper", "scissors"];
  let randomNumber = Math.floor(Math.random() * 3);
  return `Computer chose ${choices[randomNumber]}`;
}

function determineWinner(userChoice, computerChoice) {
  userChoice = userChoice.replace("Player chose ", ""); 
  computerChoice = computerChoice.replace("Computer chose ", ""); 

  if (userChoice === computerChoice) {
    return "Game was a tie!";
  }

  if (userChoice === "bomb") {
    return "Player wins!";
  }

  if (userChoice === "rock") {
    return computerChoice === "paper" ? "Computer wins!" : "Player wins!";
  }

  if (userChoice === "paper") {
    return computerChoice === "scissors" ? "Computer wins!" : "Player wins!";
  }

  if (userChoice === "scissors") {
    return computerChoice === "rock" ? "Computer wins!" : "Player wins!";
  }
}

function playGame() {
  
  let userChoice = getUserChoice(); 
  console.log(userChoice);

  let computerChoice = getComputerChoice();
  console.log(computerChoice);

  console.log(determineWinner(userChoice, computerChoice));
}

playGame();



