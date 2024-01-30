// the value saved to 'kelvin' will stay constant, equal to 293.
const kelvin = 293;

// Celsius is similar to Kelvin but the only difference is that Celsius is 273 degrees less than kelvin. 
const celsius = kelvin - 273;

// in this equation we use the formula 'Fahrenheit = Celsius * (9/5) + 32' to calculate Fahrenheit
let fahrenheit = Math.round(celsius * (9/5) + 32);

// converting from Celsius to Fahrenheit, we get a decimal number. Therefore, we use .floor() to round down the Fahrenheit temperature and save the result to the fahrenheit variable
fahrenheit = Math.floor(fahrenheit);

console.log(`The temperature is ${fahrenheit} degrees Fahrenheit`);


// The program should work for any Kelvin temperature - just change the value of Kelvin and run the program again