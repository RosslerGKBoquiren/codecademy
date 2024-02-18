-- SQL Commands

-- SELECT
-- we learned that SELECT is used every time you want to query data from 
-- a database and * means all columns
-- we can select individual columns by their names separated by a comma
SELECT column1, column2 
FROM table_name;
-- to make it easier to read, we moved FROM to another line
-- line breaks don't mean anything specific in SQL. we could write the entire query in one line and
-- it would run just fine

-- Let’s only select the name and genre columns of the table.
SELECT name, genre
FROM movies;
-- now we want to include a third column
-- edith your query so that it return name, genre, and year
SELECT name, genre, year 
FROM movies;


-- AS
-- AS is a keyword in SQL that allows you to rename a column or table using an alias. 
-- The new name can be anything you want as long as you put it inside of single quotes
-- here we renamed the Name column as Titles
SELECT name AS 'Title'
FROM movies;
-- edith the query so instead of selecting and renaming the Name column, select the imdb_rating and rename it as IMDb
SELECT imdb_rating AS 'IMDb'
FROM movies;


-- Distinct
-- DISTINCT is used to return unique values in the output. It filters out all duplicate values in 
-- specified column
SELECT tools
FROM inventory; 
-- might produce:
-- tools
-- Hammer
-- Nails
-- Nails
-- Nails

-- By adding DISTINCE before the column name
SELECT DISTINCT tools
FROM inventory;
-- the result would now be:
-- tools
-- Hammer
-- Nails


-- WHERE
-- WHERE clause filters the result set to only include rows where the following condition is true. 
-- following this format, the statement below filters the result set to only include top rated movies
-- IMDb ratings greater than 8
SELECT *
FROM movies
WHERE imdb_rating > 8;
-- comparison operators used are =, !=, >, <, >=, <=


-- LIKE 1
-- LIKE can be a useful operator when you want to compare similar values
-- name LIKE 'Se_en' is a condition evaluating the name colum for specific pattern
-- The _ means you can substitute any character here without breaking the patterns. 
SELECT * 
FROM movies
WHERE name LIKE 'Se_en';


-- LIKE 2
-- the percentage sign % is another wildcard character that can be used with LIKE
-- This statement filters the result to only include movies with names that begin with the letter 'A'
SELECT *
FROM movies
WHERE name LIKE 'A%';
-- A% matches all movies with the names that begin with letter 'A'
-- %a matches all movies that end with 'a'
-- we can also use % both before and after a pattern
SELECT *
FROM movies
WHERE name LIKE '%man%'
-- LIKE is not case sensitive.
-- edith the query so that it selects all the information about the movie titles that begin
-- with the word 'The', add space in there
SELECT *
FROM movies
WHERE name LIKE 'The %';


-- IS NULL
-- unknown values are indicated by NULL
-- it is not possible to test for NULL values with comparison operators
-- instead we use these: IS NULL, IS NOT NULL
SELECT name
FROM movies 
WHERE imdb_rating IS NOT NULL;
-- write a query to find all movies without IMDb rating. Select only the name column
SELECT name
FROM movies
WHERE imdb_rating IS NULL;


-- BETWEEN
-- BETWEEN operator is used in a WHERE clause to filter the results set within a certain range
-- it accepts two values that are either numbers, text or dates
-- for example, this statement filters the result set to only include movies with years from
-- 1990 up to including 1999
SELECT *
FROM movies
WHERE year BETWEEN 1990 AND 1999;
-- When the values are text, BETWEEN filters the result set for within the alphabetical range
-- in this statement, names that begin with letter 'A' up to, but not including 'J'
SELECT *
FROM movies
WHERE name BETWEEN 'A' AND 'J';
-- Using the BETWEEN operator, write a query that selects all information about movies whose name begins with the letters ‘D’, ‘E’, and ‘F’.
SELECT *
FROM movies
WHERE name BETWEEN 'D' and 'G';
-- Using the BETWEEN operator, write a new query that selects all information about movies that were released in the 1970’s.
SELECT *
FROM movies
WHERE year BETWEEN 1970 and 1979;


-- AND
-- sometimes we want to combine multiple conditions in a WHERE clause to make th result set more specific
-- use the AND operator to only return the 90s romance movies
SELECT *
FROM movies
Where year BETWEEN 1990 AND 1999
	AND genre = 'romance';
-- year BETWEEN 1990 AND 1999 is the 1st condition
-- genre = 'romance' is the 2nd condition
-- AND combines the two conditions

-- In the previous exercise, we retrieved every movie released in the 1970’s.
-- Now, let’s retrieve every movie released in the 70’s, that’s also well received.
SELECT *
FROM movies
WHERE year BETWEEN 1970 AND 1979
  AND imdb_rating > 8;

-- Using AND, write a new query that selects all movies made prior to 1985 that are also in the horror genre.
SELECT *
FROM movies
WHERE year < 1985
  AND genre = 'horror';


-- OR
-- Similar to AND, the OR operator can also be used to combine multiple conditions in WHERE
-- AND displays a row if ALL conditions are true
-- OR operators displays a row if ANY condition is true
SELECT *
FROM movies
WHERE year > 2014
	OR genre = 'action';

-- using OR, write a query that returns all movies that are either a romance or a comedy
SELECT *
FROM movies
WHERE genre = 'romance' OR genre = 'comedy';


-- ORDER BY
-- we can sort the reults using ORDER BY, either alphabetically or numerically. 
-- for example, if we want to sort everything by the movie's title from A to Z
SELECT * 
FROM movies
ORDER BY name;
-- ORDER BY is a clause that indicates you want to sort the result by a particular column
-- name is the specified column
-- Sometimes we want to sort things in a decreasing order
SELECT *
FROM movies
WHERE imdb_rating > 8
ORDER BY year DESC;

-- Suppose we want to retrieve the name and year columns of all the movies, ordered by their name alphabetically.
SELECT name, year
FROM movies
ORDER BY name;

-- Write a new query that retrieves the name, year, and imdb_rating columns of all the movies, ordered highest to lowest by their ratings.
SELECT name, year, imdb_rating
FROM movies
ORDER BY imdb_rating DESC;


-- LIMIT
-- LIMIT is a clause that lets you specify the maximum number of rows the result set will have. 
-- here we specify that the results can't have more than 10 rows
SELECT *
FROM movies
LIMIT 10;

-- Combining your knowledge of LIMIT and ORDER BY, write a query that returns the top 3 highest rated movies.
SELECT *
FROM movies
ORDER BY imdb_rating DESC
LIMIT 3;


-- CASE 
-- CASE statement allows us to create different output
-- Suppose we want to condense the ratings in movies to three levels:
-- if the rating is above 8 then its fantastic
-- if the rating is above 6 then its poorly received
-- else, avoid at all cost
SELECT name,
	CASE
		WHEN imdb_rating > 8 THEN 'Fantastic'
		WHEN imdb_rating > 6 THEN 'Poorly Received'
		ELSE 'Avoid at All Costs'
	END
FROM movies;
-- In the result, you have to scroll right because the column name is very long. To shorten it,
-- we can rename the column to 'Review' using AS
SELECT name,
	CASE
		WHEN imdb_rating > 8 THEN 'Fantastic'
		WHEN imdb_rating > 6 THEN 'Poorly Received'
		ELSE 'Avoid at All Costs'
	END AS 'Review'
FROM movies;

-- create my own
SELECT name, 
  CASE
    WHEN genre = 'romance' THEN 'Chill'
    WHEN genre = 'comedy' THEN 'Chill'
    ELSE 'Intense'
  END AS 'Mood'
FROM movies;

-- We just learned how to query data from a database using SQL. We also learned how to filter queries to make the information more specific and useful.

-- Let’s summarize:

-- SELECT is the clause we use every time we want to query information from a database.
-- AS renames a column or table.
-- DISTINCT return unique values.
-- WHERE is a popular command that lets you filter the results of the query based on conditions that you specify.
-- LIKE and BETWEEN are special operators.
-- AND and OR combines multiple conditions.
-- ORDER BY sorts the result.
-- LIMIT specifies the maximum number of rows that the query will return.
-- CASE creates different outputs.