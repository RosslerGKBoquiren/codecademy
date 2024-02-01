#.append() to add element to the END of the list
orders = ["daisies", "periwinkle"]
print(orders)
orders.append('tulips')
orders.append('roses')
print(orders) #['daisies', 'periwinkle', 'tulips', 'roses']


# Plus(+) when we want to add multiple items to a list, we can use + to combine two lists (also known as concatenation)
orders = ["daisy", "buttercup", "snapdragon", "gardenia", "lily"]
# Create new orders here:
new_orders = ['lilac', 'iris']
orders_combined = new_orders + orders

#Modifying List Elements
#Define a list called garden_waitlist and set the value to contain our customers (in order): "Jiho", "Adam", "Sonny", and "Alisha".
garden_waitlist = ['Jiho', 'Adam', 'Sonny', 'Alisha']
# Replace "Adam" with our other interested customer "Calla" using the index method we used in the narrative.
garden_waitlist[1] = 'Calla'
print(garden_waitlist)
#Replace Alisha with Alex using a negative index.
garden_waitlist[-1] = 'Alex'
print(garden_waitlist)


#Shrinking a list: Remove
# Let’s create a list called order_list with the following values (in this particular order):
# "Celery", "Orange Juice", "Orange", "Flatbread"
order_list = ['Celery', 'Orange Juice', 'Orange', 'Flatbread']
print(order_list)
#remove Flatbread from the order_list
order_list.remove('Flatbread')
print(order_list)
#Create a new list called new_store_order_list and assign it the following values (in order):
# "Orange", "Apple", "Mango", "Broccoli", "Mango"
new_store_order_list = ['Orange', 'Apple', 'Mango', 'Broccoli', 'Mango']
print(new_store_order_list)
#remove Mango from the list
new_store_order_list.remove('Mango')
print(new_store_order_list)
#remove onions from our new_store_order_list
new_store_order_list.remove('Onions')
print(new_store_order_list)


#Modifying 2D lists
#create a two-dimensional list called incoming_class to represent the data
incoming_class = [['Kenny', 'American', 9], ['Tanya', 'Ukrainian', 9], ['Madison', 'Indian', 7]]
print(incoming_class)
#change Madison's grade from 7 to 8
incoming_class[2][2] = 8
print(incoming_class)
#change Kenny to Ken
incoming_class[-3][-3] = 'Ken'
print(incoming_class)

# So far, we have learned:

# How to create a list
# How to access, add, remove, and modify list elements
# How to create a two-dimensional list
# How to access and modify two-dimensional list elements


#Start by turning this list of customer first names into a list called first_names
first_names = ['Ainsley', 'Ben', 'Chani', 'Depak']
#Fill our new list preferred_size with the following data, containing the preferred sizes for Ainsley, Ben, and Chani:
preferred_size = ["Small", "Large", "Medium"]
#Depak’s size is "Medium". Use .append() to add "Medium" to the preferred_size list.
# Print preferred_size to see our change.
preferred_size.append('Medium')
print(preferred_size)

#Create a two-dimensional list called customer_data using the following table as a reference for the data.
customer_data = [['Ainsley', 'Small', True], ['Ben', 'Large', False], ['Chani', 'Medium', True], ['Depak', 'Medium', False]]
print(customer_data)
#Change the data value for "Chani"‘s shipping preference to False
customer_data[2][2] = False
#Use the .remove() method to delete the shipping value from the sublist that contains Ben’s data.
customer_data[1].remove(False)
#Create a new variable customer_data_final. Combine our existing list customer_data with our new customer 2d list using + by adding it to the end of customer_data.
customer_data_final = customer_data + [["Amit", "Large", True], ["Karim", "X-Large", False]]
print(customer_data_final)