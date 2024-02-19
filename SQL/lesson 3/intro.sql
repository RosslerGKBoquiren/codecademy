-- Aggregates

-- COUNT()
-- it is a function that takes the name of a column as an argument
-- and counts the number of non-empty values in that column
SELECT COUNT(*)
FROM table_name;
-- We want to count every row so we pass * as an argument inside the parenthesis

-- lets count how many apps are in the table
SELECT COUNT(*)
FROM fake_apps
-- Add a WHERE clause in the previous query to count how many free apps are in the table
WHERE price = 0;


-- SUM()
-- function that takes the name of a column and resturns the sum of all values in that column
SELECT SUM(downloads)
FROM fake_apps;


-- MIN() MAX()
-- Function that return the highest and lowest values in a column
SELECT MAX(downloads)
FROM fake_apps;
-- MAX() takes the name of a column as an argument and returns the largest value in that column. 
-- MIN() it returns the smallest value

-- Write a new query that returns the price of the most expensive app
SELECT MAX(price)
FROM fake_apps;


-- AVG()
-- returns the average number of download for an app in our database
SELECT AVG(downloads)
FROM fake_apps;


-- ROUND()
-- function takes two arguments inside the parenthesis:
-- 1. a column name
-- 2. an integer
-- it rounds the values in the column to the number of decimal places specified by the integer
SELECT ROUND(price, 0)
FROM fake_apps;
-- Here we pass the column price and integer 0 as arguments. It rounds the values in the column to 0 decimal places
-- edit this query so that it rounds this result to 2 decimal places.
SELECT ROUND(AVG(price), 2)
FROM fake_apps;


-- GROUP BY 1
-- a clause that is used with aggregate functions in collaboration with SELECT statement 
-- to arrange identical data into groups
-- The GROUP BY statement comes after any WHERE statements but before ORDER BY or LIMIT
SELECT price, COUNT(*) 
FROM fake_apps
GROUP BY price;
-- In the previous query, add a WHERE clause to count the total number of apps that have been downloaded more than 20,000 times, at each price.
SELECT price, COUNT(*)
FROM fake_apps
WHERE downloads > 20000
GROUP BY price;


-- GROUP BY 2
-- sometimes we want to GROUP by a calculation done on a column
-- we might want to know how many movies have IMDb ratings that round to 1, 2, 3, 4, 5
SELECT ROUND(imdb_rating),
	COUNT(name)
FROM movies
GROUP BY ROUND(imdb_rating)
ORDER BY ROUND(imdb_rating);
-- the following query is equivalent to the one above:
SELECT ROUND(imdb_rating),
	COUNT(name)
FROM movies
GROUP BY 1
ORDER BY 1;
-- here 1 refers to the first column in our SELECT statement, ROUND(imdb_rating)


-- HAVING
-- SQL also allows to filter which groups to include and which to exclude
-- for instance, imagine that we want to see how many movies of different genres were produced each year
-- but we only care about years and genres with at least 10 movies
-- we can't use WHERE because we dont want to filter the rows, we want to filter groups
-- this is where HAVING comes in
SELECT year, 
	genre,
	COUNT(name)
FROM movies
GROUP BY 1, 2
HAVING COUNT(name) > 10;
-- when we want to limit the results of a query based on values of the individual rows, use WHERE
-- when we want to limit the results of a query based on aggregate property, use HAVING
-- HAVING comes after GROUP BY but before ORDER BY and LIMIT
-- Suppose we have the query below:

SELECT price, 
   ROUND(AVG(downloads)),
   COUNT(*)
FROM fake_apps
GROUP BY price;

-- Add a HAVING clause to restrict the query to price points that have more than 10 apps.
SELECT price, 
  ROUND(AVG(downloads)),
  COUNT(*)
FROM fake_apps
GROUP BY price
HAVING COUNT(*) > 10;


-- You just learned how to use aggregate functions to perform calculations on your data. What can we generalize so far?

-- COUNT(): count the number of rows
-- SUM(): the sum of the values in a column
-- MAX()/MIN(): the largest/smallest value
-- AVG(): the average of the values in a column
-- ROUND(): round the values in the column
-- Aggregate functions combine multiple rows together to form a single value of more meaningful information.

-- GROUP BY is a clause used with aggregate functions to combine data from one or more columns.
-- HAVING limit the results of a query based on an aggregate property.