#For loops
#for <temporary variable> in <collection>:
#	<action>
#a FOR keywords indicates the start of a for loop
#a <temporary variable> is used to represent the value of the element in the collection
# an IN keyword separates the temporary variable from the collection 
#an <action> to do anything on each iteration of the loop

board_games = ["Settlers of Catan", "Carcassone", "Power Grid", "Agricola", "Scrabble"]

sport_games = ["football", "hockey", "baseball", "cricket"]

for game in board_games:
  print(game) #identation must not be forgotten or expect unexpectated behavior

#Write a for loop that prints each sport in the list sport_games.
for sports in sport_games:
  print(sports) #identation must not be forgotten or expect unexpectated behavior


#using range()
#perform a certain action multiple times
#Use the range() function in a for loop to print() out the provided promise variable five times.

promise = "I will finish the python loops module!"
for temp in range(5):
  print(promise)



#while loops
#a while loop performs a set of instructions as long as a given condition is true
#while <conditional statement>:
#	<action>

#indentation is similar to a for loop, everything at the same level of indentation after the while loop
#is run on every iteration of the loop while the condition is true

#Create a variable named countdown and set the value to 10.
countdown = 10
# Define a while loop that will run while our countdown variable is greater than or equal to zero
while countdown >= 0:
	print(countdown) #We should print() the value of the countdown variable.
	countdown -= 1 #We should decrease the value of the countdown variable by 1
#print 'we have liftoff!' after the while loop
	if countdown < 0:
		print('We have liftoff!')


#while loops for List
#we can use  LENGTH in additiona to another variable to construct the while loop
#Create a variable length and set its value to be the length of the list of python_topics.
length = len(python_topics)
#Create a variable called index and initialize the value to be 0.
index = 0
# Let’s now build our loop.
while index < length:
	print('I am learning about ' + python_topics[index])
	index += 1



#Loop control: Break
#break immediately terminates a loop
dog_breeds_available_for_adoption = ["french_bulldog", "dalmatian", "shihtzu", "poodle", "collie"]
dog_breed_I_want = "dalmatian"

# Using a for loop, iterate through the dog_breeds_available_for_adoption list and print() out each dog breed.
# Use the <temporary variable> name of dog_breed in your loop declaration.
for dog_breed in dog_breeds_available_for_adoption:
  print(dog_breed)
# check if the current element inside dog_breed is equal to dog_breed_I_want. If so, print "They have the dog I want!"
  if dog_breed == dog_breed_I_want:
    print('They have the dog I want!')
    break #Add a break statement when your loop has found dog_breed_I_want so that the rest of the list does not need to be checked once we have found our breed.



#Loop control: continue
#Loop through the ages list. If an entry is less than 21, skip it and move to the next entry. Otherwise, print() the age.
ages = [12, 38, 34, 26, 21, 19, 67, 41, 17]
for num in ages:
  if num < 21:
    continue
  print(num)



#Nested loops
sales_data = [[12, 17, 22], [2, 10, 3], [5, 12, 13]]
#Start by defining a variable scoops_sold and set it to zero.
scoops_sold = 0
#Loop through the sales_data list
for location in sales_data:
  print(location)
  #Within our sales_data loop, nest a secondary loop to go through each location sublist element and add the element value to scoops_sold.
  for sublist in location:
    scoops_sold += sublist
#Print out the value of scoops_sold outside of the nested loop.    
print(scoops_sold)


#Loops List Comprehensions: Introduction
#for loop and a new list called doubled.
# We have been provided a list of grades in a physics class. Using a list comprehension, create a new list called scaled_grades that scales the class grades based on the highest score.
# Since the highest score was a 90 we simply want to add 10 points to all the grades in the list.
grades = [90, 88, 62, 76, 74, 89, 48, 57]
scaled_grades = [grade + 10 for grade in grades]
#print scaled_grades
print(scaled_grades)


#Loops List Comprehensions: Conditionals
heights = [161, 164, 156, 144, 158, 170, 163, 163, 157]
#Using a list comprehension, create a new list called can_ride_coaster that has every element from heights that is greater than 161.
can_ride_coaster = [height for height in heights if height > 161]
#print can_ride_coaster
print(can_ride_coaster)


#In this lesson, you learned

# How to write a for loop.
# How to use range in a loop.
# How to write a while loop.
# What infinite loops are and how to avoid them.
# How to control loops using break and continue.
# How to write elegant loops as list comprehensions.

# Your code below:
#Create a list called single_digits that consists of the numbers 0-9 (inclusive).
single_digits = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
#Create a for loop that goes through single_digits and prints out each one.
for digits in single_digits:
  print(single_digits[digits])
#create a list called squares. Assign it to be an empty list to begin with.
squares = []
#Inside the loop that iterates through single_digits, append the squared value of each element of single_digits to the list squares.
for number in single_digits:
  squares.append(number ** 2)
#print squares
print(squares)
#Create the list cubes using a list comprehension on the single_digits list. Each element of cubes should be an element of single_digits taken to the third power.
cubes = [digit ** 3 for digit in single_digits]
#print cube