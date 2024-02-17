# Adding by index: Insert
front_display_list = ["Mango", "Filet Mignon", "Chocolate Milk"]
print(front_display_list)
# Your code below: 
#Use .insert() to add "Pineapple" to the front of the list.
front_display_list.insert(0, 'Pineapple')

# Removing by index: Pop
data_science_topics = ["Machine Learning", "SQL", "Pandas", "Algorithms", "Statistics", "Python 3"]
print(data_science_topics)
# Your code below: 
#remove the topic 'Python3'from the list of data_science_topics using our newly learned .pop() method.
data_science_topics.pop()
print(data_science_topics)
#there is overlap on the "Algorithms" topic as well. Let’s use .pop() to remove it as well.
data_science_topics.pop(3)
print(data_science_topics)


#Consecutive lists: Range
# Your code below: 
# Modify number_list so that it is a range containing numbers starting at 0 and up to, but not including, 9
number_list = range(0, 9)
print(list(number_list))
# Create a range called zero_to_seven with the numbers 0 through 7
zero_to_seven = range(0, 8)
print(list(zero_to_seven))

#The power of range
# Your code below: 
# Modify the range() function that created the range range_five_three such that it:
# Starts at 5
# Has a difference of 3 between each item
# Ends before 15
range_five_three = range(5, 15, 3)
#Create a range called range_diff_five that:
# Starts at 0
# Has a difference of 5 between each item
# Ends before 40
range_diff_five = range(0, 40, 5)


#length
long_list = [1, 5, 6, 7, -23, 69.5, True, "very", "long", "list", "that", "keeps", "going.", "Let's", "practice", "getting", "the", "length"]
big_range = range(2, 3000, 10)
# Your code below: 
# Calculate the length of long_list and save it to the variable long_list_len.
long_list_len = len(long_list)
#print long_list_len
print(long_list_len)
#We have provided a completed range() function for the variable big_range.
# Calculate its length using the function len() and save it to a variable called big_range_length.
big_range_length = len(big_range)
#print big_range_length
print(big_range_length)
#Change the range() function that generates big_range so that it skips 100 instead of 10 steps between items.
big_range = range(2, 3000, 100)


#slicing List 1
suitcase = ["shirt", "shirt", "pants", "pants", "pajamas", "books"]
beginning = suitcase[0:4]
# Your code below: 
# Use print() to examine the variable beginning.
print(beginning)
# Modify beginning, so that it selects the first 2 elements of suitcase.
beginning = suitcase[0:2]
# Create a new list called middle that contains the middle two items ( ["pants", "pants"] ) from suitcase.
# Print middle to see the slice!
middle = (['pants', 'pants'])
print(middle)


#slicing list 2
suitcase = ["shirt", "shirt", "pants", "pants", "pajamas", "books"]
# Your code below: 
#Create a new list called last_two_elements containing the final two elements of suitcase.
last_two_elements = suitcase[-2:]
print(last_two_elements)
#Create a new list called slice_off_last_three containing all but the last three elements.
slice_off_last_three = suitcase[:-3]
print(slice_off_last_three)


#Counting in a list
votes = ["Jake", "Jake", "Laurie", "Laurie", "Laurie", "Jake", "Jake", "Jake", "Laurie", "Cassie", "Cassie", "Jake", "Jake", "Cassie", "Laurie", "Cassie", "Jake", "Jake", "Cassie", "Laurie"]
# Your code below: 
# Use .count() to determine how many students voted for "Jake" and save the value to a variable called jake_votes
jake_votes = votes.count('Jake')
#print() to examine jake_votes
print(jake_votes)


#sorting list 1
# Checkpoint 1 & 2
addresses = ["221 B Baker St.", "42 Wallaby Way", "12 Grimmauld Place", "742 Evergreen Terrace", "1600 Pennsylvania Ave", "10 Downing St."]
# Checkpoint 3
names = ["Ron", "Hermione", "Harry", "Albus", "Sirius"]
#Remove the # and whitespace in front of the line sort(names). Edit this line so that it runs without producing a NameError.
names.sort()
# Checkpoint 4 & 5
cities = ["London", "Paris", "Rome", "Los Angeles", "New York"]
sorted_cities = cities.sort()
#Use .sort() to sort addresses
addresses.sort()
#Use print() to see how addresses changed.
print(addresses)
#Use print to examine sorted_cities
print(sorted_cities)
#Edit the .sort() call on cities such that it sorts the cities in reverse order (descending).
# Print cities to see the result.
cities.sort(reverse=True)
print(cities)


#Sorting lists 2
games = ["Portal", "Minecraft", "Pacman", "Tetris", "The Sims", "Pokemon"]
# Your code below:
#Use sorted() to order games and create a new list called games_sorted
games_sorted = sorted(games)
print(games)
#Print both games and games_sorted
print(games_sorted)


inventory = ["twin bed", "twin bed", "headboard", "queen bed", "king bed", "dresser", "dresser", "table", "table", "nightstand", "nightstand", "king bed", "king bed", "twin bed", "twin bed", "sheets", "sheets", "pillow", "pillow"]

#In this lesson, we learned how to:

# Add elements to a list by index using the .insert() method.
# Remove elements from a list by index using the .pop() method.
# Generate a list using the range() function.
# Get the length of a list using the len() function.
# Select portions of a list using slicing syntax.
# Count the number of times that an element appears in a list using the .count() method.
# Sort a list of items using either the .sort() method or sorted() function.

#how many items are in the warehouse?
inventory_len = len(inventory)
#Select the first element in inventory. Save it to a variable called first.
first = inventory[1]
#Select the last element from inventory. Save it to a variable called last
last = inventory[-1]
#Select items from the inventory starting at index 2 and up to, but not including, index 6.
# Save your answer to a variable called inventory_2_6
inventory_2_6 = inventory[2: 6]
#Select the first 3 items of inventory. Save it to a variable called first_3
first_3 = inventory[:3]
# How many 'twin bed's are in inventory? Save your answer to a variable called twin_beds
twin_beds = inventory.count('twin bed')
#Remove the 5th element in the inventory. Save the value to a variable called removed_item
removed_item = inventory.pop(4)
#Use the .insert() method to place the new item as the 11th element in our inventory
inventory.insert(10, '19th Century Bed Frame')
#Sort inventory using the .sort() method or the sorted() function.
#print inventory
inventory = sorted(inventory)
print(inventory)