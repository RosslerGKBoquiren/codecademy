const celsius = 20;

// to convert celsius to newton, we use 'Celsius * (33/100)' formula
let newton = celsius * (33/100);

// round down the Newton temperature using .floor() method
newton = Math.floor(newton);

console.log(`The temperature is ${newton} Newton`);

// The program should work for any celsius temperature - just change the value of celsius and run the program again