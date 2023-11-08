// variable myAge equal to my age
const myAge = 30;
// variable earlyYears set to the value of 2 and will change
let earlyYears = 2;

earlyYears * 10.5;

// subtract 2 from variable myAge and set results to variable laterYears - possibility to change value
let laterYears = myAge - 2;

// calculate the number of dog years by multiplying variable laterYears by 4 in one step
laterYears *= 4

// store value of 'earlyYears' + 'laterYears' in variable myAgeInDogYear
myAgeInDogYears = earlyYears + laterYears;

// store my name in variable myName with all lowercase letters method
let myName = 'Ross'.toLowerCase();

// display my name and age in dog years using string interpolation to display value
console.log(`My name is ${myName}. I am ${myAge} years old in human years which is ${myAgeInDogYears} years old in dog years.`);