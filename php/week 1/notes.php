<!-- PHP fundamentals -->

1. PHP code is always enclosed by <?php ... ?>
2. Every php statement must end with a semicolon (;)
	example: echo 'Thanks for submitting the form. <br />';
3. If there is any PHP code in a web page, it's a good idea to name the file on the web server with 
.php and not .html
4. PHP variable names must begin with a dollar sign ($)

5. $_POST
A storage container known as an ARRAY. 

6. How is PHP executed?
If the a code were placed in index.php:

Closing tags are no longer required!

This works:
<?php
echo "Hello, World";

This also works:
<?php
echo      "Hello, World"; ---> it ignores white spaces

This also works:
<?php
Echo "Hello, World"; php is not case-sensitive


7. PHP comments
in php, there are two main ways to add comments to our code.
- single line comments.
// or #

Example:
// I will always remember this
echo "Hello world"; // My first PHP statement

or

# I will always remember this
echo "Hello world"; # My first PHP statement


- the second type of comment is a multi-line comment. /*... */
Example:
/* "I've never thought of PHP as more
than a simple tool to solve problems.
- Rasmus Lerdorf" */
echo "Hello, World!";