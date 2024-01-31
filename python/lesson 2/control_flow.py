#Boolean Operators: Not
statement_one = not (4 + 5 <= 9)

statement_two = not (8 * 2) != 20 - 4


credits = 120
gpa = 1.8

# If a student’s credits is not greater or equal to 120, it should print:
if not credits >= 120:
  print('You do not have enough credits to graduate')
# If their gpa is not greater or equal to 2.0, it should print:
if not gpa >= 2.0:
  print('Your GPA is not high enough to graduate')
#If their credits is not greater than or equal to 120 and their gpa is not greater than or equal to 2.0, it should print:
if not credits >= 120 and not gpa >= 2.0:
  print('You do not meet either requirement to graduate')


#Control Flow: Else Statements
#They want you to add an additional check to a previous if statement. If a student is failing to meet one or both graduation requirements, they want it to print:
credits = 120
gpa = 1.9

if (credits >= 120) and (gpa >= 2.0):
  print("You meet the requirements to graduate!")
else:
  print('You do not meet the requirements to graduate.')


#Control Flow: Else If statements
grade = 86

if grade >= 90: #If grade is 90 or higher, print "A"
  print('A')
elif grade >= 80: #Else if grade is 80 or higher, print "B"
  print('B')
elif grade >= 70: #Else if grade is 70 or higher, print "C"
  print('C')
elif grade >= 60: #Else if grade is 60 or higher, print "D"
  print('D')
else:
  print('F') #Else, print "F"


# Let’s review what we’ve learned this lesson:

# Boolean expressions are statements that can be either True or False
# A boolean variable is a variable that is set to either True or False.
# We can create boolean expressions using relational operators:
# ==: Equals
# !=: Not equals
# >: Greater than
# >=: Greater than or equal to
# <: Less than
# <=: Less than or equal to
# if statements can be used to create control flow in your code.
# else statements can be used to execute code when the conditions of an if statement are not met.
# elif statements can be used to build additional checks into your if statements