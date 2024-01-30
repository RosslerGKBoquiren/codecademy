// Helper functions - functions being called within another function
function monitorCount(rows, columns) {
    return rows * columns;
  }
  // Below monitorCount Create a function declaration named costOfMonitors that has two parameters, the first parameter is rows and the second parameter is columns
  function costOfMonitors(rows, columns) {
    return monitorCount(rows, columns) * 200;
  }
  // Declare a variable named totalCost using the const keyword. Assign to totalCost the value of calling costOfMonitors() with the arguments 5 and 4 respectively
  const totalCost = costOfMonitors(5, 4); 
  // check that the function worked properly
  console.log(totalCost);
  // output 4000