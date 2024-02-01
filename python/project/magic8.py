import random
#declare a variable name and assign it to the name of the person who will be asking the Magic 8-Ball
name = input('What is your name? ')
#declare a variable question, and assign it to a “Yes” or “No”
question = input('Ask a Yes or No question. ')
if question == '':
  print('Please ask a Yes or No question. ')
else:
  print(name + ' asks: ' + question)
  #store the answer of the Magic 8-Ball in another variable, which we’ll call answer. For now, assign this variable to an empty string.
  answer = ''
  #Declare a variable called random_number
  random_number = random.randint(1, 9)
  #add a print() statement that outputs the value of random_number, and run the program several times to ensure random values are being generated 
  # print(random_number)
  #write an if statement where if the random_number is equal to 1, answer is assigned to the phrase “Yes - definitely”
  if random_number == 1:
    answer = 'Yes - definitely'
  elif random_number == 2:
    answer = 'It is decidedly so'
  elif random_number == 3:
    answer = 'Without a doubt'
  elif random_number == 4:
    answer = 'Reply hazy, try again'
  elif random_number == 5:
    answer = 'Better not tell you now'
  elif random_number == 6:
    answer = 'My sources say no'
  elif random_number == 7:
    answer = 'Outlook not so good'
  elif random_number == 8:
    answer = 'Very doubtful'
  elif random_number == 9:
    answer = 'Ask again later'
  else:
    answer = 'Error'
  #Add a second print() statement that will output the Magic 8-Ball’s
  print('Magic 8-Ball: ' + answer)
