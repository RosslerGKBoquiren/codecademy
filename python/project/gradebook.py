last_semester_gradebook = [["politics", 80], ["latin", 96], ["dance", 97], ["architecture", 65]]

# Your code below: 
#Create a list called subjects and fill it with the classes you are taking
subject = ['physics', 'calculus', 'poetry', 'history'] 
#Create a list called grades and fill it with your scores
grades = [98 ,97, 85, 88]
#Assign and combine lists into a two-dimensional list
gradebook = [['physics', 98], ['calculus', 97], ['poetry', 85], ['history', 88]]
print(gradebook)
#Use the .append() method to add a list with the values of "computer science" and an associated grade value of 100 to our two-dimensional list of gradebook
gradebook.append(['computer science', 100])
#Use append to add ["visual arts", 93] to gradebook
gradebook.append(['visual arts', 93])
print(gradebook)
#Access the index of the grade for your visual arts class and modify it to be 5 points greater.
gradebook[5][1] = 98
print(gradebook)
#Find the grade value in your gradebook for your poetry class and use the .remove() method to delete it.
gradebook[2].remove(85)
print(gradebook)
#Use the .append() method to then add a new "Pass" value to the sublist where your poetry class is located.
gradebook[2].append('Pass')
print(gradebook)
#Create a new variable full_gradebook that combines both last_semester_gradebook and gradebook using + to have one complete grade book.
# Print full_gradebook to see our completed list.
full_gradebook = last_semester_gradebook + gradebook
print(full_gradebook)