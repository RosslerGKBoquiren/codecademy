function getSleepHours(day) {
  switch (day) {
    case 'monday':
      return 8;
    case 'tuesday':
      return 7;
    case 'wednesday':
      return 4;
    case 'thursday':
      return 9; 
    case 'friday':
      return 6;
    case 'saturday':
      return 10;
    case 'sunday':
      return 10;
  }
}

function getActualSleepHours() {
  let result = 0;
  
  result += getSleepHours('monday');
  result += getSleepHours('tuesday');
  result += getSleepHours('wednesday');
  result += getSleepHours('thursday');
  result += getSleepHours('friday');
  result += getSleepHours('saturday');
  result += getSleepHours('sunday');

  return result;
}

function getIdealSleepHours() {
  let idealHours = 8;
  return idealHours * 7;
}

function calculateSleepDebt() {
  let actualSleepHours = getActualSleepHours();
  let idealSleepHours = getIdealSleepHours();
  let sleepSurplusOrDeficit = actualSleepHours - idealSleepHours;

  if (actualSleepHours == idealSleepHours) {
    return "You have achieved the perfect amount of sleep"
  } else if (actualSleepHours > idealSleepHours) {
    return `You slept more than what is needed. Total sleep surplus ${sleepSurplusOrDeficit}`;
  } else if (actualSleepHours < idealSleepHours) {
    return `You should get some more rest. Total sleep deficit ${sleepSurplusOrDeficit}`;
  }
}

console.log(calculateSleepDebt());
