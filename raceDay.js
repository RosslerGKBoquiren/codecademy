// assign random race numbers
let raceNumber = Math.floor(Math.random() * 1000);
// create variable whether runner registered early or not
let registeredEarly = false;
// create runner's age
let runnerAge = 22;
// create control flow statement thecking if the runner is an adult and registered early. If so, add 1000 to raceNumber
if (runnerAge > 18 && registeredEarly == true) {
  raceNumber += 1000;
}
// create a separate control flow statement below the first to check age and registration time to determine race time. Runners over 18 who registered early, log a statement that they will race at 9:30am, including their raceNumber.  
if (runnerAge > 18 && registeredEarly == true) {
  console.log(`Racer ${raceNumber} will start at 9:30 am`)
  // Late adults run at 11am
} else if (runnerAge > 18 && registeredEarly == false) {
  console.log(`Racer ${raceNumber} will start at 11:00 am`)
// Youths run at 12:30pm regardless of registration time
} else if (runnerAge < 18) {
  console.log(`Racer ${raceNumber} will start at 12:30 pm`)
  // Runners exactly 18 years old will see the registration desk
} else { 
  console.log('Please see the registration desk');
}