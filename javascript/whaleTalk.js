let input = 'I wonder what Whales say to each other when they are hungry?';
const vowelsArray = ['a', 'e', 'i', 'o', 'u'];

let resultArray = [];

for (let i = 0; i < input.length; i++) {
  for (let j = 0; j < vowelsArray.length; j++) {
    if (input[i].toLowerCase() === vowelsArray[j]) {
      resultArray.push(input[i]);
    }
    if (resultArray == 'e' || resultArray == 'u') {
      resultArray.push(input[i]);
    }
  }
}

console.log(resultArray);

let resultString = resultArray.join('').toUpperCase();

console.log(resultString);