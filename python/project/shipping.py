#define a weight variable and set it equal to any number.
weight = float(input('How heavy is the package in lbs?'))
#Create an if/elif/else statement for the cost of ground shipping. It should check for weight, and print the cost of shipping a package of that weight.
#Ground Shipping
if weight <= 2:
  cost = weight * 1.50 + 20
elif 2 < weight <= 6:
  cost = weight * 3.00 + 20
elif 6 < weight <= 10:
  cost = weight * 4.00 + 20
else:
  cost = weight * 4.75 + 20
  
print('Ground Shipping Cost: $' + str(cost))

#Create a variable for the cost of premium ground shipping.
premium_ground_shipping = 125
print('Premium Ground Shipping Cost: $' + str(premium_ground_shipping))

#Drone Shipping
if weight <= 2:
  drone_cost = weight * 4.50 
elif 2 < weight <= 6:
  drone_cost = weight * 9.00 
elif 6 < weight <= 10:
  drone_cost = weight * 12.00 
else:
  drone_cost = weight * 14.25 

print('Drone Shipping Cost: $' + str(drone_cost))
