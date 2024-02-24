-- Combining tables manually
-- we have 3 tables: 
-- orders, subscription, customers
-- if we want to combine orders and customers, we would type:
SELECT *
FROM orders
JOIN customers
	ON orders.customer_id = customers.customer_id;
-- lets break down this command
-- 1. SELECT all columns 
-- 2. FROM orders specifies that we want to look in orders
-- 3. JOIN says that we want to combine information from orders with customers
-- 4. ON tells use how to combine the two tables; we want to match orders table's customer_id column with
-- customers table's customer_id column

-- Join orders table and subscriptions table and select all columns.
-- Make sure to join on the subscription_id column.
-- Checkpoint 1

SELECT *
FROM orders
JOIN subscriptions
  ON orders.subscription_id = subscriptions.subscription_id;

-- Add a second query after your first one that only selects rows from the join where description is equal to ‘Fashion Magazine’.
-- Checkpoint 2

SELECT *
FROM orders
JOIN subscriptions
  ON orders.subscription_id = subscriptions.subscription_id
WHERE subscriptions.description = 'Fashion Magazine';



-- Multiple tables inner Joins
-- Count the number of subscribers who get a print newspaper using COUNT().
SELECT COUNT(*)
FROM newspaper;
-- Count the number of subscribers who get an online newspaper using COUNT().
SELECT COUNT(*)
FROM online;
-- Join newspaper table and online table on their id columns (the unique ID of the subscriber).
-- How many rows are in this table?
SELECT COUNT(*)
FROM newspaper
JOIN online
  ON newspaper.id = online.id;


 -- Multiple tables Left Joins
 -- Let’s return to our newspaper and online subscribers.
-- Suppose we want to know how many users subscribe to the print newspaper, but not to the online.
-- Start by performing a left join of newspaper table and online table on their id columns and selecting all columns.
SELECT *
FROM newspaper
LEFT JOIN online
  ON newspaper.id = online.id;
-- In order to find which users do not subscribe to the online edition, we need to add a WHERE clause.
-- Add a second query after your first one that adds the following WHERE clause and condition
SELECT *
FROM newspaper
LEFT JOIN online
  ON newspaper.id = online.id
WHERE online.id IS NULL;


-- Multiple tables Primary Key vs Foreign Key
-- Suppose Columbia University has two tables in their database:
-- The classes table contains information on the classes that the school offers. Its primary key is id.
-- The students table contains information on all students in the school. Its primary key is id. It contains the foreign key class_id, which corresponds to the primary key of classes.
-- Perform an inner join of classes and students using the primary and foreign keys described above, and select all the columns.
SELECT *
FROM classes
JOIN students
  ON classes.id = students.class_id;



-- Multiple Tables Cross Join
-- Eventually, we’ll use a cross join to help us, but first, let’s try a simpler problem.
-- Let’s start by counting the number of customers who were subscribed to the newspaper during March.
-- Use COUNT(*) to count the number of rows and a WHERE clause to restrict to two conditions:
-- start_month <= 3
-- end_month >= 3
SELECT COUNT(*)
FROM newspaper
WHERE start_month <= 3 
  AND end_month >= 3;
-- The previous query lets us investigate one month at a time. In order to check across all months, we’re going to need to use a cross join.
-- Our database contains another table called months which contains the numbers between 1 and 12.
-- Select all columns from the cross join of newspaper and months.
SELECT *
FROM newspaper
CROSS JOIN months;
-- Create a third query where you add a WHERE statement to your cross join to restrict to two conditions:
-- start_month <= month
-- end_month >= month
-- This will select all months where a user was subscribed.
SELECT *
FROM newspaper
CROSS JOIN months
WHERE start_month <= month
  AND end_month >= month;
-- Create a final query where you aggregate over each month to count the number of subscribers.
-- Fill in the blanks in the following query:
SELECT month,
  COUNT(*) AS subscriber_count
FROM newspaper
CROSS JOIN months
WHERE start_month <= month
  AND end_month >= month
GROUP BY month;


Multiple tables Union
-- Let’s return to our newspaper and online subscriptions. We’d like to create one big table with both sets of data.
-- Use UNION to stack the newspaper table on top of the online table.
SELECT * 
FROM newspaper 
UNION 
SELECT * 
FROM online;


-- Multiple tables WITH
-- Place the whole query below into a WITH statement, inside parentheses (), and give it name previous_query:
WITH previous_query AS (
   SELECT customer_id,
      COUNT(subscription_id) AS 'subscriptions'
   FROM orders
   GROUP BY customer_id
)
SELECT customers.customer_name, 
   previous_query.subscriptions
FROM previous_query
JOIN customers
  ON previous_query.customer_id = customers.customer_id;



-- Let’s summarize what we’ve learned so far:

-- JOIN will combine rows from different tables if the join condition is true.

-- LEFT JOIN will return every row in the left table, and if the join condition is not met, NULL values are used to fill in the columns from the right table.

-- Primary key is a column that serves a unique identifier for the rows in the table.

-- Foreign key is a column that contains the primary key to another table.

-- CROSS JOIN lets us combine all rows of one table with all rows of another table.

-- UNION stacks one dataset on top of another.

-- WITH allows us to define one or more temporary tables that can be used in the final query.